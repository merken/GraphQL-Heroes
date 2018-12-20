namespace HeroApp.Data.Domain
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}