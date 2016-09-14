using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PinkFlamingoStudios.Startup))]
namespace PinkFlamingoStudios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
