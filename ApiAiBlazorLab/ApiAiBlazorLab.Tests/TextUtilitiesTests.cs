using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiAiBlazorLab.Tests
{

    public static class TextUtilities
    {
        public static string NormalizeFact(string? fact)
        {
            if (string.IsNullOrWhiteSpace(fact))
                return "No fact available.";

            fact = fact.Trim();

            return fact.EndsWith(".") ? fact : fact + ".";
        }
    }

    public class TextUtilitiesTests
    {
        [Fact]
        public void NormalizeFact_ReturnsFallback_OnNull()
        {
            string? input = null;
            var result = TextUtilities.NormalizeFact(input);
            Assert.Equal("No fact available.", result);
        }

        [Fact]
        public void NormalizeFact_ReturnsFallback_OnEmpty()
        {
            var result = TextUtilities.NormalizeFact("");
            Assert.Equal("No fact available.", result);
        }

        [Fact]
        public void NormalizeFact_AddsPeriod_WhenMissing()
        {
            var result = TextUtilities.NormalizeFact("Cats are cute");
            Assert.Equal("Cats are cute.", result);
        }

        [Fact]
        public void NormalizeFact_KeepsPeriod()
        {
            var result = TextUtilities.NormalizeFact("Cats sleep a lot.");
            Assert.Equal("Cats sleep a lot.", result);
        }
    }

}
