using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mateus.SistemaAcademico.Startup))]
namespace Mateus.SistemaAcademico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
