using Blog.Controllers;
using Blog.Interfaces;
using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog
{
    // Примечание: Инструкции по включению классического режима IIS6 или IIS7 
    // см. по ссылке http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        public static Container Container = new Container();
        protected void Application_Start()
        {
            Container.Register<ICommentDao, CommentDao>(Reuse.Transient);
            Container.Register<IPostDAO, PostDao>(Reuse.Transient);
            Container.Register<ILogger, Logger>(Reuse.Transient);
            Container.Register<IPostPresentationService, PostPresentationService>(Reuse.Singleton);
            Container.Register<HomeController, HomeController>();
             
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(typeof(MyControllerFactory));
        }
    }
}