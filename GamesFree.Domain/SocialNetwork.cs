namespace GamesFree.Domain
{
    public class SocialNetwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? UserId{ get; set; }
        public User User { get; set; }
        public int? GameId { get; set; }
        public Game Game { get; set; }
        
    }
}