using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soft1.Startup))]
namespace Soft1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
