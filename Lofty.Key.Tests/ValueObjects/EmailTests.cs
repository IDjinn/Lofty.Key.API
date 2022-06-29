using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.ValueObjects;

public class EmailTests
{
    [Theory]
    [InlineData("lucas.romero@gmail.com")]
    [InlineData("lucas.romero@outlook.com")]
    public void IsValidEmail(string mail)
    {
        var email = new Email(mail);
        Assert.True(email.IsValid);
    }

    [Theory]
    [InlineData("1234567892")]
    [InlineData("algumastring")]
    [InlineData("algumastring@")]
    [InlineData("@gmail.com")]
    public void IsNotValidEmail(string mail)
    {
        var email = new Email(mail);
        Assert.False(email.IsValid);
    }
}