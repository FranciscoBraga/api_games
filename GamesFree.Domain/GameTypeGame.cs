namespace GamesFree.Domain
{
    public class GameTypeGame
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int TypeGameId { get; set; }
        public TypeGame TypeGame { get; set; }
    }
}