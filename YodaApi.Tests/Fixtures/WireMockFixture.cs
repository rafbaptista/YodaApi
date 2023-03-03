using WireMock.Server;

namespace YodaApi.Tests.Fixtures
{
    /// <summary>
    /// This class can be shared across all tests to re-use the wiremock server
    /// Using it as a fixture, it will configure the wiremock server before running the tests and dispose after the end of all tests
    /// </summary>
    public class WireMockFixture : IDisposable
    {
        public WireMockServer Server { get; private set; }
        public HttpClient Client { get; private set; }
        public WireMockFixture()
        {
            Server = WireMockServer.Start();
            Client = Server.CreateClient();
        }
        public void Dispose()
        {
            Server.Dispose();
            Client?.Dispose();
        }
    }
}
