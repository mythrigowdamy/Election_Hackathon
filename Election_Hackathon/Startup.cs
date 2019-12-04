using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Election_Hackathon.Startup))]
namespace Election_Hackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
