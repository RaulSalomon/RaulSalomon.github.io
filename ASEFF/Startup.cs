using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASEFF.Startup))]
namespace ASEFF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
