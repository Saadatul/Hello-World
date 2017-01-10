using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HELLO_WORLD.Startup))]
namespace HELLO_WORLD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
