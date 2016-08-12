using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Search4Best.Startup))]
namespace Search4Best
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR("/signalr",new HubConfiguration()); ///// to configure signalR hubs
            ConfigureAuth(app);
        }
    }
}
