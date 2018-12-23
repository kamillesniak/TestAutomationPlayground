using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAutomationPlayground.Startup))]
namespace TestAutomationPlayground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
