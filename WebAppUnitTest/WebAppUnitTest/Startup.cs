using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppUnitTest.Startup))]
namespace WebAppUnitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
