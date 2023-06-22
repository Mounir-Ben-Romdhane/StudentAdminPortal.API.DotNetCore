using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;
using StudentAdminPortal.API.UtilityService;

namespace StudentAdminPortal.API.DataModels
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public IStudentRepository StudentRepository => 
            new SqlStudentRepository(_context);

        public IImageRepository ImageRepository => 
            new LocalStorageImageRepository(_context);

        public IUserRepository UserRepository => 
            new UserRepository(_context, _configuration, _emailService);

        private readonly StudentAdminContext _context;
        public UnitOfWork(StudentAdminContext context)
        {
            _context = context;
            
        }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
    
}
