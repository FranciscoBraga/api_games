using System;
using System.Collections.Generic;

namespace GamesFree.Domain
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateActive { get; set; }
        public List<ImageGame> ImageGames { get; set; }
        public List<SocialNetwork> SocialNetwork { get; set; }
        public List<GameTypeGame> GameTypeGames {get; set;}
        public List<GameUser> GameUsers { get; set; }
        
        
    }
}