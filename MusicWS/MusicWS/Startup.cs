using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicWS.Startup))]
namespace MusicWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
