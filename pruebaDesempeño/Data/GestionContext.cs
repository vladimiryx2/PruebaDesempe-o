using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaDesempeño.Models;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;

namespace   pruebaDesempeño.Data
{
    public class GestionContext: DbContext
    {
       public GestionContext(DbContextOptions<GestionContext> options): base(options){
            
        }
        public DbSet<Owner> Owners { get;set;}
        public DbSet<Pet> Pets { get;set;}
        public DbSet<Vet> Vets { get;set;}
        public DbSet<Quote> Quotes { get;set;}
        
    }
}