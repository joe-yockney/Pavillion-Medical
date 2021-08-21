using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PavillionMedical.Startup))]
namespace PavillionMedical
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
