using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoConjuntos.Entities
{
    class Student
    {
        public int Code { get; set; }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;

            return Code.Equals(other.Code);
        }
    }
}
