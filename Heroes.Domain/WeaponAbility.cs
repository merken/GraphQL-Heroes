namespace HeroApp.Data.Domain
{
    public class WeaponAbility
    {
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
    }
}