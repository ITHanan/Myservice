using NUnit.Framework;
using MyService.Api.Services;

namespace MyService.Tests
{
    public class GreetingServiceTests
    {
        private GreetingService _service = null!;

        [SetUp]
        public void Setup()
        {
            _service = new GreetingService();
        }

        [Test]
        public void GetGreeting_ReturnsNameGreeting()
        {
            // Arrange
            var name = "Alice";

            // Act
            var result = _service.GetGreeting(name);

            // Assert
            Assert.That(result, Is.EqualTo("Hello, Alice!"));
        }

        [Test]
        public void GetGreeting_ReturnsGuestWhenNameEmpty()
        {
            // Arrange
            var name = "";

            // Act
            var result = _service.GetGreeting(name);

            // Assert
            Assert.That(result, Is.EqualTo("Hello, guest!"));
        }
    }
}
