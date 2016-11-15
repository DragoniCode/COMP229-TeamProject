using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_TeamProject.Startup))]
namespace COMP229_TeamProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
