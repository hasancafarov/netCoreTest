using Moq;
using MyApi.Controllers;
using MyApi.Services;
using System.Net;
using Xunit;

namespace MyApi.Test.EndPoints
{
    public class ValidNameControllerTest
    {
        private readonly Mock<IValidName> _nameService;
        private readonly ValidNameController _nameController;
        private readonly string name;
        public ValidNameControllerTest()
        {
            name = string.Empty;
            _nameService = new Mock<IValidName>();
            _nameController = new ValidNameController(_nameService.Object);
        }

        [Fact]
        public void  StatusCode200_Returns_True()
        {
            _nameService.Setup(x => x.isValid(It.IsAny<string>())).Returns(true);

            var result = _nameController.Get(name);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public void StatusCode400_Returns_False()
        {
            _nameService.Setup(x => x.isValid(It.IsAny<string>())).Returns(false);

            var result = _nameController.Get(name);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }
    }
}
