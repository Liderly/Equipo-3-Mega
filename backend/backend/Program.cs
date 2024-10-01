
using backend.src.Services;
using Backend.Context;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Services;
using System.Net;
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
                options.Configuration = "localhost:6379"; 
                options.InstanceName = "BonosCache";
            });
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            builder.Services.AddDbContext<ContextDB>(options =>
            {
                
                options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
               
            });
            ///Services
            builder.Services.AddScoped<ITaskService, TaskService>();
            builder.Services.AddScoped<ISuscriberService, SuscriberService>();
            builder.Services.AddScoped<IBonusReportService, BonusReportService>();
            builder.Services.AddScoped<IEmploymentService, EmploymentService>();
            builder.Services.AddSingleton<ICacheService, CacheService>();

            
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ITokenService, TokenService>();
            builder.Services.AddScoped<AuthService>();

            //Controllers
            builder.Services.AddControllers();

            //Cors
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("OnlyFrontEnd",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
            
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
            var connectionString = builder.Configuration.GetConnectionString("Connection");

            // Mostrar la cadena de conexi�n en el log
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

            app.UseCors("OnlyFrontEnd");
            app.MapControllers();

            app.Run();
        }
    }
}