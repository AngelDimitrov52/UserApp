using src.Core.Domain.Entities;
using src.Core.Domain.Enums;

namespace XUnitTestProject
{
    public class UserTest
    {
        [Fact]
        public void TestUser_WithValidData_ShouldPass()
        {
            // Arrange
            var user = new User
            {
                Id = 1,
                Name = "Angel",
                Email = "Test@test.com",
                Type = UserType.User
            };

            // Act
            Assert.Equal(1, user.Id);
            Assert.Equal("Angel", user.Name);
            Assert.Equal("Test@test.com", user.Email);
            Assert.Equal(UserType.User, user.Type);
        }
    }
}