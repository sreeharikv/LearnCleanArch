using CleanApp.Application.Repositories;
using CleanApp.Domain.Entity;
using Microsoft.AspNetCore.Identity;

namespace CleanApp.Infrastructure.Repositories;

public class AuthenticationRepository : IAuthenticationRepository
{

    private readonly SignInManager<User> _signInManager = null;
    private readonly UserManager<User> _userManager = null;

    public AuthenticationRepository(SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }


    public async Task<SignInResult> CheckPasswordSignInAsync(User user, string password)
    {
        var result = new SignInResult();

        try
        {      
            result = await _signInManager.CheckPasswordSignInAsync(user, password, false);     
        }
        catch(Exception)
        {
            throw;
        }
        return result;
    }

    public async Task<User> GetUser(string email)
    {
        var result = new User();
        try
        {
            result = await _userManager.FindByEmailAsync(email);
        }
        catch(Exception)
        {
            throw;
        }

        return result?? new User();
    }

    public async Task<IList<string>> GetUserRole(User user)
    {
        var result = new List<string>();

        try
        {
            result = (await _userManager.GetRolesAsync(user)).ToList();
        }
         catch(Exception)
        {
            throw;
        }

        return result;
    }
}
