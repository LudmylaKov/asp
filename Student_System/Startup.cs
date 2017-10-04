using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_System.Startup))]
namespace Student_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
