using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmirAbdullinWeb.Startup))]
namespace AmirAbdullinWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
