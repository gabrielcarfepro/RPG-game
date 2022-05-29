namespace jogoRPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType, double life) : base(name, level, heroType, life)
        {

        }

        public override string Attack(string hero, double damage)
        {
            return this.name + " Lançou um ataque mágico!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.name + " Lançou um poderoso ataque mágico!\nDano: " + Bonus;
            }
            else
            {
                return this.name + " Lançou um ataque mágico!\nDano: " + Bonus;
            }
        }
    }
}