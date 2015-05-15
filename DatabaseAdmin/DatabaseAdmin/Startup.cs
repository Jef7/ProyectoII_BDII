using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseAdmin.Startup))]
namespace DatabaseAdmin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
