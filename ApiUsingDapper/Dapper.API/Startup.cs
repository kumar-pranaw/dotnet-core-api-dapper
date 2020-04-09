using Dapper.Repository.IRepository;
using Dapper.Repository.Repository;
using Dapper.Service.IService;
using Dapper.Service.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Dapper.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<ICrud>(f => new CrudRepository("Persist Security Info = false;User Id = sa;password= Pranav@k1210;Initial Catalog = DapperDb;Data Source=PRANAV;Connection Timeout=100000"));
            services.AddScoped<ICrudService, CrudService>();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Crud API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Crud API V1");
                c.RoutePrefix = string.Empty;
            });
            if (env.IsDevelopment())
            {

            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseCors(builder =>
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                );

            //app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
