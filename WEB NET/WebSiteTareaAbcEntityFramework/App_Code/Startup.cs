using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteTareaAbcEntityFramework.Startup))]
namespace WebSiteTareaAbcEntityFramework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
