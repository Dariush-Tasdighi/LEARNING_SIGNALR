using Owin;

[assembly: Microsoft.Owin.OwinStartup(typeof(SignalR.Startup), methodName: "Configuration")]
namespace SignalR
{
	public class Startup : object
	{
		public Startup() : base()
		{
		}

		public void Configuration(Owin.IAppBuilder app)
		{
			// Any connection or hub wire up and configuration should go here
			app.MapSignalR();
		}
	}
}
