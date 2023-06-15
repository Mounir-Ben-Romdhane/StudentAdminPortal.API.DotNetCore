using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.DomainModels.Dto;
using System.Security.Claims;

namespace StudentAdminPortal.API.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task<User> Authenticate(string username);
        Task<User> RegisterUser(User request);
        Task<List<Role>> GetAllRoles();

        Task<string> GetAllLaims(Guid roleId);
        Task<bool> CheckUserNameExistAsync(string username);
        Task<bool> CheckEmailExistAsync(string email);
        string CheckPasswordStrengthAsync(string password);
        string CreateJwtToken(User user);
        string CreateRefreshToken();
        Task<User> RefreshToken(TokenApiDto tokenApiDto);
        ClaimsPrincipal GetPrincipaleFromExpireToken(string token);
    }
}
