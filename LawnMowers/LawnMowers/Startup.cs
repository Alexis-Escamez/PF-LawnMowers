using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LawnMowers.Startup))]
namespace LawnMowers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
