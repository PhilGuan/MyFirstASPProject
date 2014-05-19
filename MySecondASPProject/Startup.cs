using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySecondASPProject.Startup))]
namespace MySecondASPProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
