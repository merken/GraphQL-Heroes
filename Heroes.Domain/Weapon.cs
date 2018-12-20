using System.Collections.Generic;

namespace HeroApp.Data.Domain
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Advantage { get; set; }
        public int? HeroId { get; set; }
        public Hero Hero { get; set; }
        public ICollection<WeaponAbility> LinkedAbilities { get; } = new List<WeaponAbility>();
    }
}