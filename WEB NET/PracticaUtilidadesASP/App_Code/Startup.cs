using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticaUtilidadesASP.Startup))]
namespace PracticaUtilidadesASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
