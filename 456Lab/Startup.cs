using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_456Lab.Startup))]
namespace _456Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
