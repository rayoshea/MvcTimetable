using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTimetable.Startup))]
namespace MvcTimetable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
