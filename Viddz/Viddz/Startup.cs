using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viddz.Startup))]
namespace Viddz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
