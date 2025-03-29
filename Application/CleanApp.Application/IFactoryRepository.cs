using CleanApp.Application.Repositories;

namespace CleanApp.Application;

public interface IFactoryRepository
{
    IAuthenticationRepository Authentication { get; }
}
