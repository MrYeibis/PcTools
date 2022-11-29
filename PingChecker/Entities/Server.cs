using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingChecker.Entities
{
    internal class Server
    {
        public Server(string ip, string ubication, string game) {
            Ip = ip;
            Ubication = ubication;
            GameName = game;
        }

        public string Ip { get; set; }
        public string Ubication { get; set;}
        public string GameName { get; set; }

        public static List<Server> AllServers = new List<Server>()
        {
            new Server("162.254.199.170", "Atlanta", "Valve"),
            new Server("185.25.183.163", "Dubai", "Valve"),
            new Server("155.133.255.98", "Buenos Aires", "Valve"),
            new Server("155.133.226.68", "Frankfurt", "Valve"),
            new Server("155.133.227.35", "Sao Paulo", "Valve"),
            new Server("103.28.54.164", "Hong Kong", "Valve"),
            new Server("162.254.195.72", "Los Angeles", "Valve"),
            new Server("155.133.246.34", "Madrid", "Valve"),
            new Server("162.254.193.71", "Chicago", "Valve"),
            new Server("103.10.125.146", "Sydney", "Valve"),
            new Server("155.133.239.19", "Tokyo (North)", "Valve"),
            new Server("qosping-aws-us-west-1.ol.epicgames.com", "NA-West", "EpicGames"),
            new Server("qosping-aws-us-east-1.ol.epicgames.com", "NA-East", "EpicGames"),
            new Server("qosping-aws-eu-west-3.ol.epicgames.com", "Europe", "EpicGames"),
            new Server("qosping-aws-ap-southeast-2.ol.epicgames.com", "Oceania", "EpicGames"),
            new Server("qosping-aws-sa-east-1.ol.epicgames.com", "Brazil", "EpicGames"),
            new Server("qosping-aws-ap-northeast-1.ol.epicgames.com", "Asia", "EpicGames"),
            new Server("qosping-aws-me-south-1.ol.epicgames.com", "Middle East", "EpicGames"),
        };
    }
}
