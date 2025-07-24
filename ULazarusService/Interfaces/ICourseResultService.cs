using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ULazarusData.Models;

namespace ULazarusService.Interfaces
{
    public interface ICourseResultService
    {
        Task<List<CourseResult>> GetAllAsync();
        Task<CourseResult?> GetByIdAsync(int id);
        Task AddAsync(CourseResult result);
        Task UpdateAsync(CourseResult result);
        Task DeleteAsync(int id);
    }
}
