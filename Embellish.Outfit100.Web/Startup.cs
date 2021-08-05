using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Embellish.Outfit100.Web.Startup))]
namespace Embellish.Outfit100.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
