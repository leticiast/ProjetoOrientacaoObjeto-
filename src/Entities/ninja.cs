namespace ProjetoOrientacaoObjeto.src.Entities
{
    public class ninja : Hero
    {
        public ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }  
        public string Blow()
        {
            return this.Name + " Atacou com seu golpe ninja";
        }
    }
}