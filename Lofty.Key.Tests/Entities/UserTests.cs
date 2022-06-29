using Lofty.Key.Domain.Entities;
using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.Entities;

public class UserTests
{
    [Fact]
    public void TestUsersConstructor()
    {
        var name = new Name("Lucas", "Romero");
        var email = (Email)"lucas.romero@email.com";
        var user = new User(name, "lucas.romero@email.com", "super-senha");
        Assert.NotEqual(Guid.Empty, user.Id);
        Assert.Equal("Lucas", user.Name.FirstName);
        Assert.Equal("Romero", user.Name.LastName);
        Assert.Equal(name, user.Name);
        Assert.Equal(email.ToString(), user.Email.ToString());
        Assert.Equal("super-senha", user.Password);
    }
}