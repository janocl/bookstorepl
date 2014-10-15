using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPL2.Startup))]
namespace MVCPL2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
