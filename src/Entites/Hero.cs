namespace rpg_project.src.Entites
{
    public abstract class Hero
    {
        public Hero(string name, int Lvl, string Herotype){
            this.name = name;
            this.Lvl = Lvl;
            this.Herotype = Herotype; 
        }
        public Hero(){}
        public string? name;
        public int Lvl;
        public string? Herotype;

        public override string ToString(){
            return this.name + " " + this.Lvl + " " + this.Herotype;

        }
        public virtual string power(){
            return this.name + "Atacou com a espada!";
        }

    }
}