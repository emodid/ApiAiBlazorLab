using ApiAiBlazorLab.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAiBlazorLab.Tests
{
    public class CatFactServiceTests
    {
        [Fact]
        public async Task GetRandomFact_ReturnsFact()
        {
            // Arrange
            var json = "{\"fact\":\"Cats sleep 16 hours a day.\",\"length\":32}";
            var client = new HttpClient(new FakeHandler(json));
            var service = new CatFactService(client);

            // Act
            var result = await service.GetRandomFactAsync();

            // Assert
            Assert.Equal("Cats sleep 16 hours a day.", result);
        }
    }
}
