using System;

namespace GamesFree.WebAPI.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public DateTime DateActive { get; set; }
        public bool  Active { get; set; }
    }
}