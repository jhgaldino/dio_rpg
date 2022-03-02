using rpg_project.src.Entites;
class Program {
    static void Main(string[]args){
        Lancer lancer = new Lancer("Ningirsu", 19, "World Legacy Lancer");
        Wizard wizard = new Wizard("Ib", 14, "World Legacy Wizard");
        Console.WriteLine(wizard.PowerBonus(7));
        Console.WriteLine(wizard.PowerBonus(2));

    }
}