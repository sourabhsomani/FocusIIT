using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ARNFocusIIT.Startup))]
namespace ARNFocusIIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
