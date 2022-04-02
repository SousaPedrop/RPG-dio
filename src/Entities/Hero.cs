namespace rpg.src.Entities
{
    public abstract class Hero
    {
        public string? Name;
        public int Level;
        public string? HeroType;
        public int TotalHealthPoints;
        public int HealthPoints;
        public int TotalMagicPoints;
        public int MagicPoints;


        public Hero(string Name, int Level, string HeroType, int TotalHealthPoints, int HealthPoints, int TotalMagicPoints, int MagicPoints){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.TotalHealthPoints = TotalHealthPoints;
            this.HealthPoints = HealthPoints;
            this.TotalMagicPoints = TotalMagicPoints;
            this.MagicPoints = MagicPoints;
        }

        public Hero(){}

        public override string ToString(){
            return this.Name + "\n Lv. " + this.Level + " " + this.HeroType + "\n HP " + this.HealthPoints + " / " + this.TotalHealthPoints + "\n MP " + this.MagicPoints + " / " + this.TotalMagicPoints;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada"; 
        }
    }
}