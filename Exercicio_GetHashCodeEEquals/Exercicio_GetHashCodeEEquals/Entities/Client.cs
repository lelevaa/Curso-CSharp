using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_GetHashCodeEEquals.Entities
{
    //GetHashCode e Equals personalizados
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {   
            if(!(obj is Client)) {
                return false;
            }

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
