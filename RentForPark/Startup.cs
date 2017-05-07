using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentForPark.Startup))]
namespace RentForPark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
