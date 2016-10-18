using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(irci_app.Startup))]
namespace irci_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
