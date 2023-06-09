using AutoMapper;

namespace StudentAdminPortal.API.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap: IMappingAction<DomainModels.UpdateStudentRequet, DataModels.Student>
    {
        public void Process(DomainModels.UpdateStudentRequet source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Address = new DataModels.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
    
}
