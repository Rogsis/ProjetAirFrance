using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetAirFrance.Startup))]
namespace ProjetAirFrance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
