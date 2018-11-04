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
			// broadcastSendMessage is javascript (client) function!
			Clients.All.broadcastSendMessage(name, message);
		}
	}
}
