namespace HeroApp.Data.Domain
{
    public class HeroAbility
    {
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
    }
}