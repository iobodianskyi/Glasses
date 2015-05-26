using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Glasses.Web.Startup))]
namespace Glasses.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
