using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasiPress.Startup))]
namespace EasiPress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
