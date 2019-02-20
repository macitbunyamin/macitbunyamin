using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPortFolio.Web.Startup))]
namespace MyPortFolio.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
