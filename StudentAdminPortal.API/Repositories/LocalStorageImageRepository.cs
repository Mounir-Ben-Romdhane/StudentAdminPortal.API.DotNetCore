using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public class LocalStorageImageRepository : IImageRepository
    {
        private readonly StudentAdminContext _context;

        public LocalStorageImageRepository(StudentAdminContext context)
        {
            _context = context;
        }
        public async Task<string> Upload(IFormFile file, string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Images", fileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return GetUniqueFileName(fileName);
        }

        private string GetUniqueFileName(string fileName)
        {
            return Path.Combine(@"Resources\Images", fileName); 
        }
    }
}
