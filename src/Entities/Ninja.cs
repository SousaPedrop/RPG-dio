namespace rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int TotalHealthPoints, int HealthPoints, int TotalMagicPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.TotalHealthPoints = TotalHealthPoints;
            this.HealthPoints = HealthPoints;
            this.TotalMagicPoints = TotalMagicPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack(){
            return this.Name + " Atacou com golpes";
        }

        public string Attack(int bonus){
            if(bonus > 6){
                return this.Name + " Atacou com golpes super efetivos de bonus " + bonus;
            }else{
                return this.Name + " Atacou com golpes fortes de bonus " + bonus;
            }
        }
    }
}