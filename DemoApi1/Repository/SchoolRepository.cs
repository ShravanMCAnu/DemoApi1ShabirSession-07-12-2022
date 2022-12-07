using DemoApi1.AppDbContextn;
using DemoApi1.Interface;
using DemoApi1.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApi1.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _appDbContext;
        public SchoolRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }
        public async Task<List<School>> GetAllSchool()
        {
            return await _appDbContext.Schools.ToListAsync();
        }
    }
}
