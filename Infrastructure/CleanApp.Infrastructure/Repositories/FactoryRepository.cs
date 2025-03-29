using CleanApp.Application;
using CleanApp.Application.Repositories;

namespace CleanApp.Infrastructure.Repositories;

public class FactoryRepository : IFactoryRepository
{
    public IAuthenticationRepository Authentication { get;} = null!;

    public FactoryRepository(IAuthenticationRepository authentication)
    {
        this.Authentication = authentication;
    }
}
