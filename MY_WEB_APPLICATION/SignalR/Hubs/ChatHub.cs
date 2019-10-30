using System.Threading.Tasks;

namespace SignalR.Hubs
{
	//[Microsoft.AspNet.SignalR.Hubs.HubName(hubName: "chat")]
	public class ChatHub : Microsoft.AspNet.SignalR.Hub
	{
		public ChatHub() : base()
		{
		}

		//[Microsoft.AspNet.SignalR.Hubs.HubMethodName(methodName: "send")]
		public void SendMessage(string name, string message)
		{
			// https://stackoverflow.com/questions/12472940/signalr-and-httpcontext-session

			string username =
				System.Web.HttpContext.Current.User.Identity.Name;

			// OR

			string token =
				System.Web.HttpContext.Current.Request.Headers["token"];

			// broadcastSendMessage is javascript (client) function!
			Clients.All.broadcastSendMessage(name, message);
		}

		public override Task OnConnected()
		{
			return base.OnConnected();
		}

		public override Task OnDisconnected(bool stopCalled)
		{
			return base.OnDisconnected(stopCalled);
		}

		public override Task OnReconnected()
		{
			return base.OnReconnected();
		}
	}
}
