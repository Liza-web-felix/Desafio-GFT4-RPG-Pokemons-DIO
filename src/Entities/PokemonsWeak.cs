namespace Dotnet_POO.src.Entities
{
       public class FragilHero : Pokemons
    {
        public FragilHero(string name, int level, int hp, int mp, string heroType) 
                        : base(name, level, hp, mp, heroType)
        {
        }

        public override string Attack()
        {
           return $"{this.Name} atacou com Bug Buzz";
        }

        public override string Attack(int bonus)
        {
            return $"{this.Name} atacou com a Poison Sting, com bonus de {bonus}";
        }

    }
}