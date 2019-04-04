namespace GamesFree.Domain
{
    public class ImageGame
    {
        public int ImageGameId { get; set; }
        public string Path { get; set; }
        public int GameId{get; set; }
        public Game Game { get; set; }
    }
}