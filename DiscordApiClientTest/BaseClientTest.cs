using DiscordApiClient;
using Xunit;

namespace DiscordApiClientTest
{
    public class BaseClientTest
    {
        [Fact]
        public void ConstructorTest()
        {
            var config01 = new DiscordClientConfig("123");

            var client01 = new DiscordClient(config01);

            Assert.NotNull(client01);
        }
    }
}
