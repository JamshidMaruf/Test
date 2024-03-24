namespace TestApp
{
	public class Turnstile
	{
		public event EventHandler<NotificationArgs> Sender;
		public void Enter()
		{
			if (Sender != null)
				Sender(this, new NotificationArgs { Message = "Entered" });
		}
	}
}