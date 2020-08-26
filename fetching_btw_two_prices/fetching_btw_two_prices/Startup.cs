using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fetching_btw_two_prices.Startup))]
namespace fetching_btw_two_prices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
