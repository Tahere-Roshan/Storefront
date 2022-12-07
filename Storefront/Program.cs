using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Storefront.Model;

namespace Storefront
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            // builder.Services.AddDbContext<TourContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<TourContext>(option => option.UseSqlServer(connectionString));


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //builder.Services.ConfigureSwaggerGen(setup =>
            //{
            //    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            //    {
            //        Title = "Tour",
            //        Version = "v1"
            //    });
            //});

            builder.Services.AddCors(options =>
            {
                    options.AddDefaultPolicy(builder =>
                {
                   
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            

            builder.Services.AddCors(options => options.AddPolicy("TrAgencyPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()));

            //builder.Services.AddCors(options => options.AddPolicy);


            var ConnectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<TourContext>(option => option.UseSqlServer(ConnectionStrings));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseCors();

            app.MapControllers().RequireCors("TrAgencyPolicy");

            app.Run();
        }
    }
}