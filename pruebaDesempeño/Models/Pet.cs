using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Veterinaria.Models;

namespace pruebaDesempeño.Models
{
     public class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Specie { get; set; }
        public int Race { get; set; }
        public DateTime DateBirth { get; set; }
        public int OwnerId { get; set; }
        public string? Photo { get; set; }
        public Owner? Owner { get; set; } 
        public List<Quote>? Quotes { get; set; } 
    }
}    