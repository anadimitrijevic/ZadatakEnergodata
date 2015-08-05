using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZadatakEnergodata.Startup))]
namespace ZadatakEnergodata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
