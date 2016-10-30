using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdamV1.Startup))]
namespace AdamV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
