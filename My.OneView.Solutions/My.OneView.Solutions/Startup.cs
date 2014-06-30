using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My.OneView.Solutions.Startup))]
namespace My.OneView.Solutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
