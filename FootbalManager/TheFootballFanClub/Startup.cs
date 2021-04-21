using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheFootballFanClub.Startup))]
namespace TheFootballFanClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
