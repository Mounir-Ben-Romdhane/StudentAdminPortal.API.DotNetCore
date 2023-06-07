using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IUnitOfWork uow;

        //private readonly IStudentRepository studentRepository;
        //private readonly IMapper mapper;


        //public StudentsController(IStudentRepository studentRepository,
        //    IMapper mapper)
        //{
        //    this.studentRepository = studentRepository;
        //    this.mapper = mapper;
        //}

        public StudentsController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await uow.StudentRepository.GetStudentsAsync();

           return Ok(students);
        }
    }
}
