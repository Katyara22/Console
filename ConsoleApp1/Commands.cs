using System;

namespace Commands
{
    internal class Command
    {
        public byte _windowsVersion = 10;
        public ushort maxPlayer = 255;
        
        public bool Online = true;

        public void WindowsVersion()
        {
			var MainFaile = new ConsoleApp1.Program();

			Console.WriteLine($"Mincrosoft Windows [Version {_windowsVersion}]\n" +
	                          $"{MainFaile.disc} Mincrosoft Copration. All rights reserved");
	        Console.WriteLine();
        }

		public void CMDCommands()
        {
			var MincraftServer = new Server.MincraftServer();
            var MainFaile = new ConsoleApp1.Program(); 

			Console.Write($"{MainFaile.disc}:/Users/{MainFaile.userName}> ");
            string Command = Console.ReadLine();
            
            switch (Command)
            {
	            case "Profil":
		            Console.Write("My login ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{MainFaile.userLogin}");
		            Console.ResetColor();
		            
		            Console.Write("My password ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{MainFaile.userpassword}");
		            Console.ResetColor();
		            
		            Console.Write("My nickname ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{MainFaile.userName}");
		            Console.ResetColor();

		            CMDCommands();
		            break;
	            
	            case "ChekCommands":
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine("Commands");
		            Console.ResetColor();
		            Console.WriteLine("Profil\nChekCommands\nServer");
		            
		            CMDCommands();
		            break;
	            
	            case "Server":
		            ServerCommands();
		            break;

	            default:
		            Console.WriteLine($"{Command} is not reconized as an internal or external command,\n" +
		                              $"operable program or batch file.");
        
		            CMDCommands();
		            break;
            }
        }

		public void ServerCommands()
		{
			var MincraftServer = new Server.MincraftServer();
			var MainFaile = new ConsoleApp1.Program(); 
			
			Console.Write($"{MainFaile.disc}:/Server/Users/{MainFaile.userName}> ");
            string input = Console.ReadLine();
            
            switch (input)
            {
	            case "Server.Commands":
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine("Commands");
		            Console.ResetColor();
		            Console.WriteLine("Server.Commands\nServer.Create\nServer.Log\n" 
		                              + "Server.Connect\nServer.Status\nServer.Switch.Status\n" 
		                              + "Server.Switch.Max.Player\nServer.Online");

		            ServerCommands();
		            break;
	            
	            case "Server.Create":
                    MincraftServer.CreateServer();
                    break;
	            
	            case "Server.Log":
		            Console.Write("Server name ");
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine($"{MincraftServer.nameServer}");
		            Console.ResetColor();
		            
		            Console.Write("Serever online ");
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine($"{Online}");
		            Console.ResetColor();
		            
		            Console.Write("Serever max player ");
		            Console.ForegroundColor = ConsoleColor.Green;
		            Console.WriteLine($"{maxPlayer}");
		            Console.ResetColor();
		            
		            Console.Write("Serever player online ");
		            Console.ForegroundColor = ConsoleColor.Green;
		            Console.WriteLine($"{MincraftServer.playerOnline}");
		            Console.ResetColor();

		            ServerCommands();
		            break;
                
                case "Server.Connect":
                    Console.Write("please enter a player name ");
                    
                    string namePleyrs = Console.ReadLine();
                    
                    MincraftServer.namePlayer = namePleyrs;
                    
                    MincraftServer.ConnectToServer();
                    break;
    
                case "Server.Status":
                    Console.Write("Server status ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{Online}");
                    Console.ResetColor();
    
                    MincraftServer.Server();

                    ServerCommands();
                    break;
                
                case "Server.Switch.Status":
                    Console.Write("Server status true of false");
                    
                    var swichServerStatus = Convert.ToBoolean(Console.ReadLine());
                    
                    Console.Write("Server status ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{Online}");
                    
                    Online = swichServerStatus;
                    
                    ServerCommands();
                    break;
                
                case "Server.Switch.Max.Player":
                    Console.Write("enter a number (Maximun 65535): ");
                    
                    var swichServerMaxPlayer = Convert.ToBoolean(Console.ReadLine());
                    
                    Online = swichServerMaxPlayer;
                    break;

	            case "Server.Online":
                    Console.WriteLine($"Server online {MincraftServer.playerOnline}: ");
                    
                    ServerCommands();
                    break;
    
                default:
                    Console.WriteLine($"{input} is not reconized as an internal or external command,\n" +
                        "operable program or batch file.");
                    
                    ServerCommands();
                    break;
            }
		}
    }
}