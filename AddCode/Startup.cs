using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddCode.Startup))]
namespace AddCode
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
