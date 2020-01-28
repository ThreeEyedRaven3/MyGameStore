using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGameStore.Startup))]
namespace MyGameStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
