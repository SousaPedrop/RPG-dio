namespace rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int TotalHealthPoints, int HealthPoints, int TotalMagicPoints, int MagicPoints){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.TotalHealthPoints = TotalHealthPoints;
            this.HealthPoints = HealthPoints;
            this.TotalMagicPoints = TotalMagicPoints;
            this.MagicPoints = MagicPoints;
        }

       public override string Attack(){
            return this.Name + " Lançou magia"; 
        }

        public string Attack(int bonus){
            if (bonus > 6){
               return this.Name + " Lançou Magia super efetiva com bonus de " + bonus; 
            }else
            {                
                return this.Name + " Lançou Magia fraca com bonus de " + bonus;
            }
        }
    }
}