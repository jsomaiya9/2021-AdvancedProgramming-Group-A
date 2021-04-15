using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheFanClub.Startup))]
namespace TheFanClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
