using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using pruebaDesempeño.Models;

namespace Veterinaria.Models
{
   public class Quote
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PetId { get; set; }
        public int VetId { get; set; }
        public string? Description { get; set; }
        public Pet? Pet { get; set; } 
        public Vet? Vet { get; set; }
    }
}