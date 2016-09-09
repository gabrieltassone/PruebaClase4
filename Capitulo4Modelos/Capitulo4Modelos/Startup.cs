using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capitulo4Modelos.Startup))]
namespace Capitulo4Modelos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
