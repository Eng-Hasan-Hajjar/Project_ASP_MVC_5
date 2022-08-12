using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mybroject.Startup))]
namespace mybroject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
