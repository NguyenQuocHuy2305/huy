using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_nguyenquohuy.Startup))]
namespace NguyenQuocHuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
