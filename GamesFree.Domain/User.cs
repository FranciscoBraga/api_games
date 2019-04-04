using System;
using System.Collections.Generic;

namespace GamesFree.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool term { get; set; }
        public DateTime Subscriptid { get; set; }
        public string ImageUser { get; set; }
        public List<SocialNetwork> SocialNetwork { get; set; }
        public List<GameUser> GameUsers { get; set; }
    }
}