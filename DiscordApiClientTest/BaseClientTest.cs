using DiscordApiClient;
using Xunit;

namespace DiscordApiClientTest
{
    public class BaseClientTest
    {
        [Fact]
        public void ConstructorTest()
        {
            var newGuildId = "456";
            var config01 = new DiscordClientConfig("123");

            var client01 = new DiscordClient(config01);

            Assert.NotNull(client01);
            Assert.Equal(config01, client01.Config);

            client01.Config.GuildId = newGuildId;
            Assert.Equal(newGuildId, config01.GuildId);
        }
    }
}
