using PrimeService01.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeService01.UnitTests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf24()
        {
            var result = _primeService.IsPrime(24);

            Assert.False(result, $"24 should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf23()
        {
            var result = _primeService.IsPrime(23);

            Assert.True(result, $"23 should be prime");
        }

    }
}
