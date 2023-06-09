using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IUnitOfWork uow;


        private readonly IMapper mapper;
        public GendersController(IUnitOfWork uow,
            IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var gendersList = await uow.StudentRepository.GetAllGenders();

            if (gendersList == null || !gendersList.Any())
            {
                return NotFound();
            }

            return Ok(mapper.Map<List<DomainModels.Gender>>(gendersList));
        }
    }
}
