namespace jogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        string name;
        int level;
        string heroType;

        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Lançou um ataque mágico!";
        }
    }
}