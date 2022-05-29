namespace jogoRPG.src.Entities
{
    public abstract class Hero
    {
        public int extraLifePercentagePerLevel = 30;

        public Hero(string name, int level, string heroType, double life)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.life = life;
        }

        public string name;
        public int level;
        public string heroType;
        public double life;

        public override string ToString()
        {
            return $"Características do Personagem\n Nome: {this.name}\n Level: {this.level}\n Classe: {this.heroType}";
        }

        public virtual string Attack(string hero, double damage)
        {
            this.DamageTaken(damage);
            return this.name + " Atacou com a sua espada!";
        }

        public string DamageTaken(double damage)
        {
            this.life -= damage;
            return $"{this.name} - vida: {this.life}";
        }
    }
}