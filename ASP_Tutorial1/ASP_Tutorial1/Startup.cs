using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Tutorial1.Startup))]
namespace ASP_Tutorial1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
