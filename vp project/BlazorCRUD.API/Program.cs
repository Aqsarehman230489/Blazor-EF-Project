using BlazorCRUD.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.API
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConString")));
            // Add Identity services
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configure the database connection
            var ConString = builder.Configuration.GetConnectionString("ConString");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConString));

            // Add CORS policy
            builder.Services.AddCors(options => options.AddPolicy("BlazorPolicy", policyBuilder =>
            {
                policyBuilder.WithOrigins("https://localhost:7293") // Replace with your Blazor app's origin
                             .AllowAnyHeader()
                             .AllowAnyMethod();
            }));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("BlazorPolicy");
            app.UseHttpsRedirection();

            // Add authentication middleware
            app.UseAuthentication();

            // Add authorization middleware
            app.UseAuthorization();

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
