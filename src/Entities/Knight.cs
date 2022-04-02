namespace rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int TotalHealthPoints, int HealthPoints, int TotalMagicPoints, int MagicPoints){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.TotalHealthPoints = TotalHealthPoints;
            this.HealthPoints = HealthPoints;
            this.TotalMagicPoints = TotalMagicPoints;
            this.MagicPoints = MagicPoints;
        }
        public string Attack(int bonus){
            return this.Name + " Atacou com sua espada com bonus de " + bonus; 
        }
    }
}