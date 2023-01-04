using System;

namespace Server
{
    internal class MincraftServer
    {
        public string namePlayer = "";
        public string nameServer = ""; //Mincraft
        
        public short playerOnline = 1798;

        public void CreateServer()
        {
            var commands = new Commands.Command();
            
            Console.Write("Create server name> ");
            nameServer = Console.ReadLine();
            
            Console.Write("Specify the number of players on the server in numbers> ");
            commands.maxPlayer = Convert.ToByte(Console.ReadLine());

            Console.Write("Set the server status to true/false> ");
            commands.CmdOnline = Convert.ToBoolean(Console.ReadLine());
        }

        public void ConnectToServer()
        {
            var commands = new Commands.Command();

            if (commands.CmdOnline == true)
            {
                if (namePlayer == "")
                {
                    Console.WriteLine("an error occurred because you did not specify a player name");
                }
                else
                {
                    playerOnline++;
                    
                    Console.Write($"Player {namePlayer} connect to server {nameServer} player online ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{playerOnline}/{commands.maxPlayer}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("an error occurred because the server is not online");
            }

            commands.CmdCommands();
        }
        
        public void Server()
        {
            
        }
        
    }
}