using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETaxiDotNet.Startup))]
namespace ETaxiDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
