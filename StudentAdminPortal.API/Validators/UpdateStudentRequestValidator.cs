using FluentValidation;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Validators
{
    public class UpdateStudentRequestValidator: AbstractValidator<UpdateStudentRequet>
    {
        public UpdateStudentRequestValidator(IStudentRepository studentRepository)
        {
            RuleFor(s => s.FirstName).NotEmpty();
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.DateofBirth).NotEmpty();
            RuleFor(s => s.Email).NotEmpty().EmailAddress();
            RuleFor(s => s.Mobile).GreaterThan(99999).LessThan(99999999999);
            RuleFor(s => s.GenderId).NotEmpty().Must(id =>
            {
                var gander = studentRepository.GetAllGenders().Result.ToList()
                .FirstOrDefault(s => s.Id == id);
                if (gander != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Please select a valid Gender !");
            RuleFor(s => s.PhysicalAddress).NotEmpty();
            RuleFor(s => s.PostalAddress).NotEmpty();
        }
    }
}
