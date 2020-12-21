using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTracker.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Game Game { get; set; }
        public int GameId { get; set; }
        public Dictionary<string, int> stats { get; set; }
    }
}