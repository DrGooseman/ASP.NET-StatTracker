using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StatTracker.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string statsString { get; set; }
        public Dictionary<string, float> Stats
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string, float>>(statsString);
            }
            set
            {
                statsString = JsonConvert.SerializeObject(value);
            }
        }
    }
}