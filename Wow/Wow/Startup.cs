using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wow.Startup))]
namespace Wow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
