using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Entity
    {
        public string Id { get; private set; }

        public string Placa { get; private set; } 
        public Entity(string id, string placa)
        {
            Id = id;
            Placa = placa;
        }

 
    }
}
