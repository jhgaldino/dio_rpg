namespace rpg_project.src.Entites
{
    public class Wizard : Hero
    {
            public Wizard(string name, int Lvl, string Herotype){
            this.name = name;
            this.Lvl = Lvl;
            this.Herotype = Herotype; 
        }
    
        
            public virtual string Power(){
            return this.name + "Conjurou um feitiço!";
        }
            public string PowerBonus(int Bonus){
            if (Bonus > 6){
                return this.name + "Conjurou um feitiço forte com bonus de ataque de : " + Bonus;
            }else{
                return this.name + "Conjurou um feitiço fraco com bonus de ataque de : " + Bonus;
            }
            
        }
            

    }
}
        