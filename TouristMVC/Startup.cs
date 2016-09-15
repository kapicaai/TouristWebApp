using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TouristMVC.Startup))]
namespace TouristMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
