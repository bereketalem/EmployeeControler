using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeControler.Startup))]
namespace EmployeeControler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
