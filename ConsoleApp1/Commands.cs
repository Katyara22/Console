using System;

namespace Commands
{
    internal class Command
    {
	    public string disc = "C"; //C                      
	    public string userName = "CmdUser"; //Lügen              
	    public string userLogin = "user"; //Lügen             
	    public string userpassword = "user"; // Strong@@      
	    
        public byte _windowsVersion = 10;
        
        public ushort maxPlayer = 255;
        
        public bool ServerOnline = true;
        public bool CmdOnline = false;
        
        public void WindowsVersion()
        {
	        Console.WriteLine($"Mincrosoft Windows [Version {_windowsVersion}]\n" +
	                          $"{disc} Mincrosoft Copration. All rights reserved " + 
	                          "check all commands through\nChek.Commands and in Server.Commands");
	        Console.WriteLine();
        }

        public void CmdCommands()
        {
	        Console.Write($"{disc}:/Users/{userName}> ");
            string Command = Console.ReadLine();
            
            switch (Command)
            {
	            case "Profil":
		            Console.WriteLine();
		            Console.Write("My login ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{userLogin}");
		            Console.ResetColor();
		            
		            Console.Write("My password ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{userpassword}");
		            Console.ResetColor();
		            
		            Console.Write("My nickname ");
		            Console.ForegroundColor = ConsoleColor.Cyan;
		            Console.WriteLine($"{userName}");
		            Console.ResetColor();
		            Console.WriteLine();

		            CmdCommands();
		            break;
	            
	            case "Chek.Commands":
		            Console.WriteLine();
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine("Commands");
		            Console.ResetColor();
		            Console.WriteLine("Profil\nChekCommands\nServer");
		            Console.WriteLine();
		            
		            CmdCommands();
		            break;
	            
	            case "Switch.Disc":
		            break;
	            
	            case "Color":
		            Console.Write("write the name of the color Red/Yellow> ");
		            
		            String color = Console.ReadLine();

		            switch (color)
		            {
			            case "Red":
				            Console.ForegroundColor = ConsoleColor.Red;

				            CmdCommands();
				            break;
			            
			            case "Yellow":
				            Console.ForegroundColor = ConsoleColor.Yellow;

				            CmdCommands();
				            break;
			            
			            default:
				            Console.WriteLine($"{Command} is not reconized as an internal or external command,\n" +
				                              $"operable program or batch file.");
        
				            CmdCommands();
				            break;
		            }
		            
		            break;
	            
	            case "Server":
		            ServerCommands();
		            break;

	            default:
		            Console.WriteLine($"{Command} is not reconized as an internal or external command,\n" +
		                              $"operable program or batch file.");
        
		            CmdCommands();
		            break;
            }
        }

        public void ServerCommands()
		{
			var MincraftServer = new Server.MincraftServer();
			// var MainFaile = new ConsoleApp1.Program(); 
			
			Console.Write($"{disc}:/Server/Users/{userName}> ");
            string input = Console.ReadLine();
            
            switch (input)
            {
	            case "Server.Commands":
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine();
		            Console.WriteLine("Commands");
		            Console.ResetColor();
		            Console.WriteLine("Server.Commands\nServer.Create\nServer.Log\n" 
		                              + "Server.Connect\nServer.Status\nServer.Switch.Status\n" 
		                              + "Server.Switch.Max.Player\nServer.Online");
		            Console.WriteLine();

		            ServerCommands();
		            break;

	            case "Server.Create":
                    MincraftServer.CreateServer();
                    
                    ServerCommands();
                    break;
	            
	            case "Server.Log":
		            Console.WriteLine();
		            Console.Write("Server name ");
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine($"{MincraftServer.nameServer}");
		            Console.ResetColor();
		            
		            Console.Write("Serever online ");
		            Console.ForegroundColor = ConsoleColor.Blue;
		            Console.WriteLine($"{CmdOnline}");
		            Console.ResetColor();
		            
		            Console.Write("Serever max player ");
		            Console.ForegroundColor = ConsoleColor.Green;
		            Console.WriteLine($"{maxPlayer}");
		            Console.ResetColor();
		            
		            Console.Write("Serever player online ");
		            Console.ForegroundColor = ConsoleColor.Green;
		            Console.WriteLine($"{MincraftServer.playerOnline}");
		            Console.WriteLine();
		            Console.ResetColor();

		            ServerCommands();
		            break;
                
                case "Server.Connect":
                    Console.Write("please enter a player name> ");
                    
                    string namePleyrs = Console.ReadLine();
                    
                    MincraftServer.namePlayer = namePleyrs;
                    
                    MincraftServer.ConnectToServer();
                    break;
    
                case "Server.Status":
	                Console.WriteLine();
                    Console.Write("Server status ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{CmdOnline}");
                    Console.WriteLine();
                    Console.ResetColor();
    
                    MincraftServer.Server();

                    ServerCommands();
                    break;
                
                case "Server.Switch.Status":
                    Console.Write("Server status true of false ");
                    
                    var swichServerStatus = Convert.ToBoolean(Console.ReadLine());
                    
                    Console.Write("Server status ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{CmdOnline}");
                    Console.ResetColor();
                    
                    CmdOnline = swichServerStatus;
                    
                    ServerCommands();
                    break;
                
                case "Server.Switch.Max.Player":
                    Console.Write("enter a number (Maximun 65535): ");
                    
                    var swichServerMaxPlayer = Convert.ToBoolean(Console.ReadLine());
                    
                    CmdOnline = swichServerMaxPlayer;
                    break;

	            case "Server.Online":
		            Console.WriteLine();
                    Console.Write("Server online: ");
		            Console.ForegroundColor = ConsoleColor.DarkBlue;
		            Console.WriteLine($"{ServerOnline}");
		            Console.ResetColor();
                    Console.WriteLine();
                    
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