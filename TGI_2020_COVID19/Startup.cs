using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TGI_2020_COVID19.Startup))]
namespace TGI_2020_COVID19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
