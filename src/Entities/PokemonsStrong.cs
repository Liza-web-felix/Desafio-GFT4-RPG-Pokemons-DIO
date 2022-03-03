namespace Dotnet_POO.src.Entities
{
     public class PotênciaHero : Pokemons
    {
        public PotênciaHero(string name, int level, int hp, int mp, string heroType) 
        : base(name, level, hp, mp, heroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Bola de fogo";
        }

        public override string Attack(int bonus)
        {
            return $"{this.Name} bola de fogo, com Bonus de {bonus}";
        }
    }
}