using Microsoft.Owin;
using Owin;
using ProjectCS;

[assembly: OwinStartup(typeof(Startup))]
namespace ProjectCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
