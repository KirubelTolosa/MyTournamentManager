using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Tournament.Web.API
{
  public class WebApiApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
      AutofacWebapiConfig.Initialize(new HttpConfiguration());

      
        var builder = new ContainerBuilder();

        // Get your HttpConfiguration.
        var config = GlobalConfiguration.Configuration;

        // Register your Web API controllers.
        builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        // OPTIONAL: Register the Autofac filter provider.
        builder.RegisterWebApiFilterProvider(config);

        // OPTIONAL: Register the Autofac model binder provider.
        builder.RegisterWebApiModelBinderProvider();

     
         MyTournament.BLL.DIModule.RegisterServices(builder);

        // Set the dependency resolver to be Autofac.
        var container = builder.Build();
        config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        
       

    }
  }
}
