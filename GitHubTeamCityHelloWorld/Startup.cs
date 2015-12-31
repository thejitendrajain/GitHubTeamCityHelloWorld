using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTeamCityHelloWorld.Startup))]
namespace GitHubTeamCityHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
