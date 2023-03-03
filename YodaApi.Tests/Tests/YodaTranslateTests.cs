using System.Net.Http.Json;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using YodaApi.Responses;
using YodaApi.Tests.Fixtures;

namespace YodaApi.Tests.Tests
{
    public class YodaTranslateTests : IClassFixture<WireMockFixture>
    {
        private readonly WireMockFixture _wireMockFixture;
        public YodaTranslateTests(WireMockFixture wireMockFixture)
        {
            _wireMockFixture = wireMockFixture;
        }

        [Fact]
        public async Task YodaTranslate()
        {
            //Arrange
            string route = "/translate/yoda";

            var yodaResponse = new ResponseWrapper<YodaTranslateResponse>
            {
                Data = new()
                {
                    OriginalText = "You must have patience, my young Padawan",
                    TranslatedText = "Patience you must have, my young Padawan"
                }
            };

            _wireMockFixture.Server.Given(
                Request.Create()
                    .WithPath(route)
                    .UsingGet())
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBodyAsJson(yodaResponse, true)
                );

            //Act
            var response = await _wireMockFixture.Client.GetFromJsonAsync<ResponseWrapper<YodaTranslateResponse>>(route);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(yodaResponse.Data.OriginalText, response.Data.OriginalText);
            Assert.Equal(yodaResponse.Data.TranslatedText, response.Data.TranslatedText);
        }
    }
}