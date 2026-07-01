using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoDictionary.Entities
{
    class Cadidato
    {
        public string Name { get; set; }
        public int Votos { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Cadidato))
            {
                return false;
            }

            Cadidato other = obj as Cadidato;

            return Name.Equals(other.Name);
        }
    }
}
