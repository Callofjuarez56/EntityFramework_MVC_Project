using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication6.Managers.FirstMod;
//using WebApplication6.Manager;
using WebApplication6.Managers.Groups;
using WebApplication6.Managers.numbers;
using WebApplication6.Managers.SecondMod;
using WebApplication6.Managers.Subjects;
using WebApplication6.Storage;

namespace WebApplication6
{
    public class Startup
    {

        private IConfigurationRoot _confRoot;
        public Startup(IHostingEnvironment hostEnv)
        {
            _confRoot = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("DBSettings.json").Build();
        }  // принимает информацию об окружении хостинга
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) // позволяет прописать все сервисы
        {                                                          // связь интерфейса с классом
            services.AddMvc(option => option.EnableEndpointRouting = false);// добавляем технологию MVC
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options => options.UseSqlServer(_confRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<IGroupManager, GroupManager>();
            services.AddTransient<Number_sys, Numb>();
            services.AddTransient<ISubjectManager, SubjectManager>();
            services.AddTransient<IFirstModManager, FirstModManager>();
            services.AddTransient<ISecondModManager, SecondModManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // прописать параметры приложения
        {
            app.UseDeveloperExceptionPage(); // Страница с ошибками
            app.UseStatusCodePages();  // сген ошибки
            app.UseStaticFiles();  //
            app.UseMvcWithDefaultRoute(); // 
            app.UseMvc(routes =>
            {
               routes.MapRoute(
               name: "default",  template: "{controller=Group}/{action=HomePage}/{id?}");
            }); 
        }
    }
}
