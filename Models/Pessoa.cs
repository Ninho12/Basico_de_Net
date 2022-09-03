using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basico_de_Net.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade   { get; set; }

        public void apresentar(){
            
            Console.WriteLine("Meu nome é: "+{nome}+" e minha idade é: "+{idade});

        }
    }
}