using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
        Task<List<Gender>> GetAllGenders();
        Task<bool> Exist(Guid studentId);
        Task<Student> UpdateStudentAsync(Guid studentId,Student request);

        Task<Student> DeleteStudentAsync(Guid studentId);
    }
}
