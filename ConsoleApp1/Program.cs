using System;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var commands = new Commands.Command();
			var program = new Program();
			
			commands.WindowsVersion();
			commands.CmdCommands();
			// program.SingIn();
			// program.LogIn();
		}

		public void LogIn()
		{
			var commands = new Commands.Command();

			Console.WriteLine("Write your login");
			string login = Console.ReadLine();

			Console.WriteLine("Write your password");
			string password = Console.ReadLine();

			if (login == commands.userLogin)
			{
				if (password == commands.userpassword)
				{
					commands.CmdCommands();
				}
				else
				{
					Console.WriteLine("Error");
				}
			}
			else
			{
				Console.WriteLine("Error");
			}
			
			commands.CmdCommands();  
		}

		public void SingIn()
		{
			var commands = new Commands.Command();

			Console.Write("Create your own login> ");
			commands.userLogin = Console.ReadLine();

			Console.Write("Create your own password> ");
			commands.userpassword = Console.ReadLine();

			Console.Write("Create your own nickname> ");
			commands.userName = Console.ReadLine();
			
			Console.Write("Create your own disc> ");
			commands.disc = Console.ReadLine();

			commands.CmdCommands();
		}
	}
}