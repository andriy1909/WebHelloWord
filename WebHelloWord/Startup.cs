using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHelloWord.Startup))]
namespace WebHelloWord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
