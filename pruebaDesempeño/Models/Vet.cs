using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaDesempeño.Models;
using Veterinaria.Models;



namespace pruebaDesempeño.Models

{
    public class Vet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public List<Quote>? Quotes { get; set; }
    }
}    