using System.Collections.Generic;

namespace HeroApp.Data.Domain
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Advantage { get; set; }
        public ICollection<HeroAbility> LinkedHeroes { get; } = new List<HeroAbility>();
        public ICollection<WeaponAbility> LinkedWeapons { get; } = new List<WeaponAbility>();
    }
}