// A tool for ping your favorite game servers

using PingChecker.Entities;
using System.Net.NetworkInformation;

MainMenu();

void MainMenu()
{
    var loop = true;

    while (loop)
    {
        Console.Clear();
        Console.WriteLine(@"Welcome to PingChecker, here you can find who are the best server to play your favorite game.
Please Choose an option:
1. Valve (CS:GO)
2. EpicGames (Fortnite)
3. Others/Minecraft/IP");
        var mainSelectedOption = Convert.ToInt16(Console.ReadLine());

        switch (mainSelectedOption)
        {
            case 1:
                PrintPingGameServersSubMenu("Valve");
                break;
            case 2:
                PrintPingGameServersSubMenu("EpicGames");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Please introduce the server Ip:");
                var customServerIp = Console.ReadLine();
                Console.Clear();
                PingAndPrintCustomServerSubMenu(customServerIp);
                break;
        }
    }
}
void PrintPingGameServersSubMenu(string gameName)
{
    Console.Clear();
    var gameSelected = new Game(gameName);
    var pingsResult = gameSelected.PingServers();
    pingsResult.ForEach(x => Console.WriteLine(x));
    Console.WriteLine("Press any key to back");
    var subMenuKeyPressed = Console.ReadKey();
    switch (subMenuKeyPressed)
    {
        default:
            break;
    }
}
void PingAndPrintCustomServerSubMenu(string serverIp)
{
    var ping = new Ping();
    var result = ping.Send(serverIp);
    Console.WriteLine($"-{serverIp}: {result.RoundtripTime}");
    Console.WriteLine("Press any key to back");
    var subMenuKeyPressed = Console.ReadKey();
    switch (subMenuKeyPressed)
    {
        default:
            break;
    }
}