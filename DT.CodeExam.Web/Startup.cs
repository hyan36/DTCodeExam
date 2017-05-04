using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DT.CodeExam.Web.Startup))]
namespace DT.CodeExam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
