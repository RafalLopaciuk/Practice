using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LooksLikeVidly.Startup))]
namespace LooksLikeVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
