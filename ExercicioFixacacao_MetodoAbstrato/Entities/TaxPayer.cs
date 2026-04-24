namespace ExercicioFixacacao_MetodoAbstrato.Entities
{
    abstract class TaxPayer //para ter um método abstrato precisa de uma classe abstrata
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public TaxPayer() { }
        public TaxPayer(string name, double anualincome) {
            Name = name;
            AnualIncome = anualincome;
        }

        //método abstrato, não é chamado diretamente
        public abstract double Tax();
    }
}
