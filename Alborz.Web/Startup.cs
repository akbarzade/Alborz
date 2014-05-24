using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alborz.Web.Startup))]
namespace Alborz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
