﻿using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.DataModels
{
    public class UnitOfWork: IUnitOfWork
    { 

       public IStudentRepository StudentRepository => 
            new SqlStudentRepository(_context);

        public IImageRepository ImageRepository => 
            new LocalStorageImageRepository(_context);

        public IUserRepository UserRepository => 
            new UserRepository(_context);

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
