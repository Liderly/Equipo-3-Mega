
using Backend.Context;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Services;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           builder.Services.AddScoped<ITaskService, TaskService>();

            builder.Services.AddHttpClient();
            // builder.Services.AddStackExchangeRedisCache(options =>
            // {
            //     options.Configuration = builder.Configuration.GetConnectionString("RedisCache");
            // });
            builder.Services.AddDbContext<ContextDB>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}