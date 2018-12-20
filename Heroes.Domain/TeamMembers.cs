namespace HeroApp.Data.Domain
{
    public class TeamMember
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int MemberId { get; set; }
        public Hero Member { get; set; }
    }
}