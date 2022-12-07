using DemoApi1.Model;

namespace DemoApi1.Interface
{
    public interface ISchoolRepository
    {
        Task<List<School>> GetAllSchool();
    }
}
