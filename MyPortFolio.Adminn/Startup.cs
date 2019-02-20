using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPortFolio.Adminn.Startup))]
namespace MyPortFolio.Adminn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
