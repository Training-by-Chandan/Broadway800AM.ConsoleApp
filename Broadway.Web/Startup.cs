using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Broadway.Web.Startup))]
namespace Broadway.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
