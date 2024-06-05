using pruebaDesempeño.Data;
using pruebaDesempeño.Models;
using Microsoft.EntityFrameworkCore;

namespace pruebaDesempeño.Services.Owners
{
    public class OwnersService : IOwnersService
    {

        private readonly GestionContext _context;

        public OwnersService(GestionContext context)
        {
            _context = context;
        }

        public async Task<Owner> CreateOwnerAsync(Owner owner)
        {
            var newOwner = new Owner()

            await _context.Owners.AddAsync(newOwner);
            await _context.SaveChangesAsync();
            return newOwner;
        }
        public async Task<Owner> EditOwnerAsync(int Id)
        {
            var existingOwner = await _context.Owners.FindAsync(Id);
            if (existingOwner!= null)
            {
                await _context.SaveChangesAsync();
                return existingOwner;
            }
         return null; 
        }       
        public void DeleteCategoryAsync(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();

        }

        public async Task<IEnumerable<Owner>> GetAllCategoriesAsync()
        {
            return await _context.Owners.ToListAsync();
        }
    

        public async Task<Owner> GetCategoryByIdAsync(int id)
        {
            return await _context.Owners.FindAsync(id);
        }

        

        public void DeleteOwnerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetAllOwnersAsync()
        {
            throw new NotImplementedException();
        }

      

        public Task<Owner> GetOwnerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Owner> GetOwnwerByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetAllOwnerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetOwnersByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetOwnerByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<Owner> EditOwnerAsync(Owner owners)
        {
            throw new NotImplementedException();
        }
    }
}