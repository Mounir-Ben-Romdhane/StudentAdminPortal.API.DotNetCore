using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.DataModels
{
    public interface IUnitOfWork: IDisposable
    {
        IStudentRepository StudentRepository { get; }

        IImageRepository ImageRepository { get; }

        int Complete();
        
    }
}
