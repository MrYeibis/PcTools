using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace PingChecker.Entities
{
    internal class Game
    {
        public Game(string name) {
            Name = name;
        }
        public string Name { get; set; }
        public List<Server> Servers = new List<Server>();

        public List<string> PingServers()
        {
            Servers = Server.AllServers.Where(server => server.GameName == Name).ToList();
            var list = new List<string>();
            Ping pinger = new Ping();
            PingReply result;
            foreach (var server in Servers)
            {
                result = pinger.Send(server.Ip);
                if (result.Status != IPStatus.Success)
                {
                    list.Add($"-{server.Ubication}: {result.Status}");
                } else
                {
                    list.Add($"-{server.Ubication}: {result.RoundtripTime}");
                }
            }
            return list;
        }
    }
}
