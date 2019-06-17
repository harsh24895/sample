using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sample_test.Startup))]
namespace sample_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
