namespace TestApp
{
	public class Notification
	{
		public static void Send(object sender, NotificationArgs args)
		{
			Console.WriteLine(args.Message);
		}
	}
}