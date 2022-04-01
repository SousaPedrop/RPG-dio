namespace rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(int bonus){
            return this.Name + " Atacou com sua espada com bonus de " + bonus; 
        }
    }
}