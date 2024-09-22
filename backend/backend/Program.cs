
using backend.src.Services;
using Backend.Context;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Services;
using System.Reflection;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHttpClient();
            builder.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = builder.Configuration["Caching:RedisConnection"]; 
                options.InstanceName = "BonosCache";
            });
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            builder.Services.AddDbContext<ContextDB>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
               
            });
            ///Services
            builder.Services.AddScoped<ITaskService, TaskService>();
            builder.Services.AddScoped<ISuscriberService, SuscriberService>();
            builder.Services.AddSingleton<ICacheService, CacheService>();

            //Controllers
            builder.Services.AddControllers();

            // Swagger
            builder.Services.AddSwaggerGen();
            builder.Services.AddMemoryCache();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(docs => {
                docs.SwaggerDoc("v1", new OpenApiInfo { Title = "MegaHack-Docs", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                docs.IncludeXmlComments(xmlPath);
            });
            var app = builder.Build();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Mostrar la cadena de conexión en el log
            app.Logger.LogInformation("Connection string: {ConnectionString} en modo {1}", connectionString, Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(docs =>
                {
                    docs.SwaggerEndpoint("/swagger/v1/swagger.json", "Mega-Hack docs v1");
                });
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}