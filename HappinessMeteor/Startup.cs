using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappinessMeteor.Startup))]
namespace HappinessMeteor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
