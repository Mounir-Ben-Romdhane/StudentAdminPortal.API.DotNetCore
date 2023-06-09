﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IUnitOfWork uow;

        //private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;


        //public StudentsController(IStudentRepository studentRepository,
        //    IMapper mapper)
        //{
        //    this.studentRepository = studentRepository;
        //    this.mapper = mapper;
        //}

        public StudentsController(IUnitOfWork uow,
            IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await uow.StudentRepository.GetStudentsAsync();

           return Ok(mapper.Map<List<DomainModels.Student>>(students));
        }

        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            //Fetch student details

            var student = await uow.StudentRepository.GetStudentAsync(studentId);

            if (student == null)
            { 
                return NotFound();
            }
            //Return student
            return Ok(mapper.Map<DomainModels.Student>(student));
        }

        [HttpPut]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> UpdateStudentAsync([FromRoute] Guid studentId, [FromBody] UpdateStudentRequet requet)
        {
            //Check user exist
           if(await uow.StudentRepository.Exist(studentId))
            {
                //Update student
                var updatedStudent = await uow.StudentRepository.UpdateStudentAsync(studentId, mapper.Map<DataModels.Student>(requet));

                if(updatedStudent != null)
                {
                    //Return student
                    return Ok(mapper.Map<DomainModels.Student>(updatedStudent));
                }
                
            }
                return NotFound();
            
        }
    }
}