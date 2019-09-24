using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sd2_mis4200_conroy.Startup))]
namespace sd2_mis4200_conroy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
