namespace jogoRPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {

        }

        public override string Attack()
        {
            return this.name + " Lançou um ataque mágico!";
        }
    }
}