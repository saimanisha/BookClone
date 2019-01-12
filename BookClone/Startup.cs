using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookClone.Startup))]
namespace BookClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
