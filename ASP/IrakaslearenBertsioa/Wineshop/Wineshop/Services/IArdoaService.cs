using Wineshop.Models;

namespace Wineshop.Services
{
    public interface IArdoaService
    {
        Task<IList<ArdoaUpeltegi>> GetMota(int id);
    }
}
