using Autofac;
using Autofac.Extras.DynamicProxy;
using FineAdmin.Repository;
using FineAdmin.Web.Quartz;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Module = Autofac.Module;

namespace FineAdmin.Web
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
            //�������ᣨ��ͼ�е����ı�html���룩
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

            //�ڴ滺��
            services.AddMemoryCache();
            //redis����
            //services.AddStackExchangeRedisCache(t =>
            //{
            //    t.Configuration = Configuration.GetValue<string>("Redis:Configuration");
            //    t.InstanceName = Configuration.GetValue<string>("Redis:InstanceName");
            //});
            services.AddDistributedMemoryCache();

            //����session(session�Ǹ�������cache�����ִ洢Դ�ص�)
            services.AddSession(opts =>
            {
                opts.IdleTimeout = TimeSpan.FromMinutes(60); //����Session���ó�ʱʱ��(��Чʱ������)
                opts.Cookie.Name = "FineAdminWeb_cookie";
                opts.Cookie.HttpOnly = true;

            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews()
               //����json���صĸ�ʽ
               .AddJsonOptions(options =>
               {
                   options.JsonSerializerOptions.PropertyNamingPolicy = null;
                   options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
                   options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
               })
                // ��Controller���뵽Services��
                .AddControllersAsServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Login/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            //����ģ��Ŀ¼
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        #region autofac

        /// <summary>
        /// ������ӵķ�������autofacע�����
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new RmesAutoFacModule());
        }

        public class RmesAutoFacModule : Module
        {
            private static Autofac.IContainer _container;

            protected override void Load(ContainerBuilder builder)
            {

                //����quartz��ʱ����(����)
                builder.RegisterType<JobCenter>()
                    .PropertiesAutowired()
                    .SingleInstance();

                builder.RegisterType<DbContext>()
                    .PropertiesAutowired()
                    .InstancePerDependency();

                //WebAPIֻ������services��repository�Ľӿڣ���������ʵ�ֵ�dll��
                //�������ʵ�ֵĳ��򼯣���dll������binĿ¼�¼��ɣ���������dll
                var iServices = Assembly.Load("FineAdmin.IService");
                var services = Assembly.Load("FineAdmin.Service");
                var iRepository = Assembly.Load("FineAdmin.IRepository");
                var repository = Assembly.Load("FineAdmin.Repository");

                //��������Լ���������Ľӿں�ʵ�־���Services��β����ʵ�ַ���ӿںͷ���ʵ�ֵ�����
                builder.RegisterAssemblyTypes(iServices, services)
                  .Where(t => t.Name.EndsWith("Service"))
                  .AsImplementedInterfaces().PropertiesAutowired()//��������ע��
                  .InstancePerDependency();//Ĭ��ģʽ��ÿ�ε��ã���������ʵ��������ÿ�����󶼴���һ���µĶ���

                //��������Լ�������ݷ��ʲ�Ľӿں�ʵ�־���Repository��β����ʵ�����ݷ��ʽӿں����ݷ���ʵ�ֵ�����
                builder.RegisterAssemblyTypes(iRepository, repository)
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces().PropertiesAutowired()
                  .InstancePerDependency();


                var controllerBaseType = typeof(ControllerBase);
                builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                    .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
                    .PropertiesAutowired() // ��������ע��
                    .EnableClassInterceptors(); // ������Controller����ʹ��������
                // �ֶ�����
                builder.RegisterBuildCallback(container => _container = container);
            }

            public static Autofac.IContainer GetContainer()
            {
                return _container;
            }
        }
        #endregion

        public class DateTimeConverter : JsonConverter<DateTime>
        {
            /// <summary>
            /// ��ȡ������DateTime��ʽ
            /// <para>Ĭ��Ϊ: yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            public string DateTimeFormat { get; set; } = "yyyy-MM-dd HH:mm:ss";

            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
                => DateTime.Parse(reader.GetString());

            public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(this.DateTimeFormat));
        }
    }
}
