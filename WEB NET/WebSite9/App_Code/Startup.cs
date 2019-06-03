using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite9.Startup))]
namespace WebSite9
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
