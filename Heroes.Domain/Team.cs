using System.Collections.Generic;

namespace HeroApp.Data.Domain
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LeaderId { get; set; }
        public Hero Leader { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public ICollection<TeamMember> TeamMembers { get; } = new List<TeamMember>();
    }
}