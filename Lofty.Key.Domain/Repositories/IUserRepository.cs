using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Domain.Repositories;

public interface IUserRepository
{
    public Task<bool> EmailAlreadyExists(Email email);
}