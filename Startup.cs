using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(online_Bookstore.Startup))]
namespace online_Bookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
