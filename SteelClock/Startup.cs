using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SteelClock.Startup))]
namespace SteelClock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
