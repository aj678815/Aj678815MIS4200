using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aj678815MIS4200.Startup))]
namespace Aj678815MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
