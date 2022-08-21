using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApi.Services;

namespace MyApi.Test.Services
{
    public class IValidNameServiceTest
    {
        private IValidName _nameService;
        public IValidNameServiceTest()
        {
            _nameService = new ValidName();
        }

        [Fact]
        public void Should_isValidName_Return_False_When_ParamisEmpty()
        {
            string name = string.Empty;
            var result = _nameService.isValid(name);
            Assert.False(result);
        }

        [Fact]
        public void Should_isValidName_Return_True_When_ParamisnotEmpty()
        {
            string name = "Hasan Jafarov";
            var result = _nameService.isValid(name);
            Assert.True(result);
        }
    }
}
