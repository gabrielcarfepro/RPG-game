namespace jogoRPG.src.Entities
{
    public class Hero
    {

        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public string name;
        public int level;
        public string heroType;

        public override string ToString()
        {
            return $"Características do Personagem\n Nome: {this.name}\n Level: {this.level}\n Classe: {this.heroType}";
        }

        public virtual string Attack()
        {
            return this.name + " Atacou com a sua espada!";
        }
    }
}