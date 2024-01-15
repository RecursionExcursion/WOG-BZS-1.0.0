using System.Text.Json.Serialization;
using WOG_1._0._0.Repository;
using WOG_1._0._0.Service;

namespace WOG_1._0._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                            .AddJsonOptions(options =>
                            {
                                options.JsonSerializerOptions
                                       .Converters.Add(new JsonStringEnumConverter());
                            });
            builder.Services.AddScoped<WorkoutService>();
            builder.Services.AddScoped<WorkoutRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
