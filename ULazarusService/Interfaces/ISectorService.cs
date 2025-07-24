using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ULazarusData.Models;

namespace ULazarusService.Interfaces
{
    public interface ISectorService
    {
        Task<List<Sector>> GetAllAsync();
        Task<Sector?> GetByIdAsync(int id);
        Task AddAsync(Sector sector);
        Task UpdateAsync(Sector sector);
        Task DeleteAsync(int id);
    }
}

