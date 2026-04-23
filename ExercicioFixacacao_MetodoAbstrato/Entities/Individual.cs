using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacacao_MetodoAbstrato.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualincome):base( name, anualincome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if( AnualIncome < 20 / 100)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
