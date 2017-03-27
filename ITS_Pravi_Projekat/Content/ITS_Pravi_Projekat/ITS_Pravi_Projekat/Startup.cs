using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITS_Pravi_Projekat.Startup))]
namespace ITS_Pravi_Projekat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
