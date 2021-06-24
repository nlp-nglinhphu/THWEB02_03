using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THWEB0203.Startup))]
namespace THWEB0203
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
