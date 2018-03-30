using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoboticsTool.Startup))]
namespace RoboticsTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
