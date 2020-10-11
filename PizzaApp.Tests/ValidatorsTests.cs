using PizzaApp.Logic.User;
using PizzaApp.OutputMessages;
using Xunit;

namespace PizzaApp.Tests
{
    public class ValidatorsTests
    {
        [Fact]
        public void CheckEmail_WhenUserEmailIsInvalid_ShouldReturnErrorWithMessage()
        {
            //Arrange
            (bool, string) expected = (false, UserMessages.InvalidEmailFormat);
            string email = "test%test.com";

            //Act
            var result = new DataValidationManager().CheckEmail(email);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckEmail_WhenUserEmailIsCorrect_ShouldReturnCorrectResult()
        {
            //Arrange
            (bool, string) expected = (true, string.Empty);
            string email = "test@test.com";

            //Act
            var result = new DataValidationManager().CheckEmail(email);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("Example123")]
        [InlineData("Example example")]
        public void CheckUserName_WhenUserDataIsInvalid_ShouldReturnErrorWithMessage(string sentence)
        {
            //Arrange
            (bool, string) expected = (false, UserMessages.InvalidFirstName);

            //Act
            var result = new DataValidationManager().CheckFirstName(sentence);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckUserName_WhenUserDataCorrect_ShouldReturnCorrectResult()
        {
            //Arrange
            (bool, string) expected = (true, string.Empty);
            string userName = "Kamil";

            //Act
            var result = new DataValidationManager().CheckFirstName(userName);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Koktajlowo")]
        [InlineData("123456")]
        public void CheckAdress_WhenUserDataIsInvalid_ShouldReturnErrorWithMessage(string adress)
        {
            //Arrange
            (bool, string) expected = (false, UserMessages.InvalidAddressFormat);

            //Act
            var result = new DataValidationManager().CheckAddress(adress);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckAdress_WhenUserDataIsCorrect_ShouldReturnCorrectResult()
        {
            //Arrange
            (bool, string) expected = (true, string.Empty);
            string adress = "Koktajlowo 16";

            //Act
            var result = new DataValidationManager().CheckAddress(adress);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}