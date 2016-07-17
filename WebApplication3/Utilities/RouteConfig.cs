using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{


    public class WebApiConfig
    {
       
            /// <summary>
            /// 注册webapi路由
            /// </summary>
            /// <param name="config"></param>
            public static void Register(HttpConfiguration config)
            {
                var json = config.Formatters.JsonFormatter;
                // 解决json序列化时的循环引用问题
                json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                // 移除XML序列化器
                config.Formatters.Remove(config.Formatters.XmlFormatter);

                config.Routes.MapHttpRoute(
                   name: "actionApi",
                   routeTemplate: "api/{controller}/{action}/{id}",
                   defaults: new
                   {
                       action = RouteParameter.Optional,
                       id = RouteParameter.Optional
                   }
               );
            }
        

    }
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
        }
    }

}