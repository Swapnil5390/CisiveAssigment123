
namespace WebApplicationApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.

                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();


                var allowedOrigins = builder.Configuration.GetValue<string>("allowedOrigins")!.Split(",");
                builder.Services.AddCors(options =>
                {
                    options.AddDefaultPolicy(policy =>
                    {
                        policy.WithOrigins(allowedOrigins).AllowAnyHeader().AllowAnyMethod();

                    });
                });

                var app = builder.Build();

                ////Enable CORS
                //app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());




                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseCors();
                app.UseAuthorization();


                app.MapControllers();

                app.Run();

            }
            //    public void ConfigureServices(IServiceCollection services)
            //    {
            //        services.AddCors(options =>
            //        {
            //            options.AddPolicy("AllowAllOrigins",
            //                builder =>
            //                {
            //                    builder.AllowAnyOrigin()
            //                           .AllowAnyMethod()
            //                           .AllowAnyHeader();
            //                });
            //        });
            //        services.AddControllers();
            //    }

            //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            //    {
            //        app.UseCors("AllowAllOrigins");
            //        // Other middleware...
            //    }
            //}
        }
    }

}
