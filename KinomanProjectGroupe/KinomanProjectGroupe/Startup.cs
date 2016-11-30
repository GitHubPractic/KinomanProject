using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KinomanProjectGroupe.Startup))]
namespace KinomanProjectGroupe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
