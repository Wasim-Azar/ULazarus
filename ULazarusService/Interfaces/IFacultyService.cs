using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ULazarusData.Models;

namespace ULazarusService.Interfaces
{
    public interface IFacultyService
    {
        Task<List<Faculty>> GetAllAsync();
        Task<Faculty?> GetByIdAsync(int id);
        Task AddAsync(Faculty faculty);
        Task UpdateAsync(Faculty faculty);
        Task DeleteAsync(int id);
    }
}

