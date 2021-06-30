using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieShow.Startup))]
namespace MovieShow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
