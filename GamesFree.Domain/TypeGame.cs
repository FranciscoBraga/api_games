using System.Collections.Generic;

namespace GamesFree.Domain
{
    public class TypeGame
    {
        public int TypeGameId { get; set; }
        public string Type { get; set; }
        public List<GameTypeGame> GameTypeGames {get; set;}
      

    }
}