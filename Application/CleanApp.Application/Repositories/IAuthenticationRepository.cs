using CleanApp.Domain.Entity;
using Microsoft.AspNetCore.Identity;

namespace CleanApp.Application.Repositories;

public interface IAuthenticationRepository
{
    Task<SignInResult> CheckPasswordSignInAsync(User user, string password);

    Task<User> GetUser(string email);
    
    Task<IList<string>> GetUserRole(User user);
}
