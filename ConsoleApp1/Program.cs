using System;

namespace ConsoleApp1
{
	internal class Program
	{
		public char disc = 'C';
		
		public string userName = "Lügen"; //Lügen
		public string userLogin = "Lügen"; //Lügen
		public string userpassword = "Strong@@"; // Strong@@

		private static void Main(string[] args)
		{
			var commands = new Commands.Command();

			commands.WindowsVersion();
			//SingIn();
			//LogIn();
			commands.CMDCommands();
		}

		public void LogIn()
		{
			var commands = new Commands.Command();
			commands.CMDCommands();

			Console.WriteLine("Write your login");
			string login = Console.ReadLine();

			Console.WriteLine("Write your password");
			string password = Console.ReadLine();

			if (login == userLogin)
				if (password == userpassword)
				{
					commands.CMDCommands();
				}
				else
					Console.WriteLine("Error");
			else
				Console.WriteLine("Error");
		}

		private void SingIn()
		{
			var commands = new Commands.Command();

			Console.Write("Create your own login ");
			userLogin = Console.ReadLine();

			Console.Write("Create your own password ");
			userpassword = Console.ReadLine();

			Console.Write("Create your own nickname ");
			userName = Console.ReadLine();

			commands.CMDCommands();
			
			
		}
	}
}