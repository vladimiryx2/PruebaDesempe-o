
using pruebaDesempeño.Models;
namespace pruebaDesempeño.Services.Owners
{
    public interface IOwnersService
    {
        Task<Owner> CreateOwnerAsync(Owner owner);
        Task<Owner> EditOwnerAsync(Owner owners);
        Task<IEnumerable<Owner>> GetAllOwnersAsync();
        Task<Owner> GetOwnerByIdAsync(int id);
        Task<Owner> GetOwnwerByIdAsync(int id);
        Task<IEnumerable<Owner>> GetAllOwnerAsync();
    
    }
}