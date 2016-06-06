using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoRegretsWebsite.Startup))]
namespace NoRegretsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
