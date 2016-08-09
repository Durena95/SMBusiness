using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMBusiness.Startup))]
namespace SMBusiness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
