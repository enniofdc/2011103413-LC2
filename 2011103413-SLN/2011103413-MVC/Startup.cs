using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011103413_MVC.Startup))]
namespace _2011103413_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
