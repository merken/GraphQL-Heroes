using System.Collections.Generic;
using System.Linq;

namespace HeroApp.Data.Domain
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public ICollection<HeroAbility> LinkedAbilities { get; } = new List<HeroAbility>();
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
        public ICollection<TeamMember> LinkedTeams { get; } = new List<TeamMember>();
    }
}