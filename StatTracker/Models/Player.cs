using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StatTracker.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Game Game { get; set; }
        public int GameId { get; set; }
        public string StatsString { get; set; }
        public Dictionary<string, float> Stats
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string, float>>(StatsString);
            }
            set
            {
                StatsString = JsonConvert.SerializeObject(value);
            }
        }
    }
}