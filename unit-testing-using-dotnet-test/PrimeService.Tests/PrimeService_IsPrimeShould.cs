using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        [Fact] //declares test method that's run by the test runner. 
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
        [Fact]
        public void IsPrime_InputIs2_ReturnTrue(){
            bool result = _primeService.IsPrime(2);

            Assert.True(result,"2");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(0)]
        public void IsPrimce_InputIsLessThan2_ReturnFalse(int value){
            bool result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }
    }
}   