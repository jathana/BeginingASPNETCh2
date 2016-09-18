using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeginingASPNETCh2.Startup))]
namespace BeginingASPNETCh2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
