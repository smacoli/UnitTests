using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    public class StringValidationsTests
    {
        private StringValidations _validations;

        public StringValidationsTests() 
        {
            _validations = new StringValidations();
        }

        [Fact]
        public void MustCountCharsReturnThree()
        {
            // Arrange
            string text = "qwe";

            // Act
            int result = _validations.CharCount(text);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
