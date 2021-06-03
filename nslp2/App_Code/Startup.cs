using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nslp2.Startup))]
namespace nslp2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
