using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DTCodingChanllenge.Startup))]
namespace DTCodingChanllenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
