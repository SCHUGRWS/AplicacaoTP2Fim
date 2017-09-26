using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacaoTP2Fim.Startup))]
namespace AplicacaoTP2Fim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
