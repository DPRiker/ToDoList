using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ang2MVC.Startup))]
namespace Ang2MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
