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
            string email = "Infermus123%vp.pl";

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
            string email = "Infermus123@vp.pl";

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
        public void CheckString_WhenUserDataIsInvalid_ShouldReturnErrorWithMessage(string sentence)
        {
            //Arrange
            (bool, string) expected = (false, UserMessages.InvalidUserDataFormatInput);

            //Act
            var result = new DataValidationManager().CheckString(sentence);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckString_WhenUserDataCorrect_ShouldReturnCorrectResult()
        {
            //Arrange
            (bool, string) expected = (true, string.Empty);
            string userName = "Kamil";

            //Act
            var result = new DataValidationManager().CheckString(userName);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Koktajlowo")]
        [InlineData("123456")]
        public void CheckAdress_WhenUserDataIsInvalid_ShouldReturnErrorWithMessage(string adress)
        {
            //Arrange
            (bool, string) expected = (false, UserMessages.InvalidUserDataFormatInput);

            //Act
            var result = new DataValidationManager().CheckAdress(adress);

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
            var result = new DataValidationManager().CheckAdress(adress);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}