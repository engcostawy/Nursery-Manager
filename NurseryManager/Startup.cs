using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NurseryManager.Startup))]
namespace NurseryManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
