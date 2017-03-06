using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentiMVC.Startup))]
namespace StudentiMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
