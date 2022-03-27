namespace ProjetoOrientacaoObjeto.src.Entities
{
    public class blackWizard : Hero
    {
        public blackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6 ){
                return this.Name + " Lançou Magia super efetiva de " + Bonus;
            }else {
                return this.Name + " Lançou Magia com força fraca com bonus  " + Bonus;
            }
    }
}
}