using DiscordApiClient;
using Xunit;

namespace DiscordApiClientTest
{
    public class DiscordClientConfigTest
    {
        [Fact]
        public void ConstructorTest()
        {
            var apiKey01 = "Test123";
            var config01 = new DiscordClientConfig(apiKey01);

            Assert.Equal(apiKey01, config01.ApiKey);
            Assert.Null(config01.GuildId);

            var apiKey02 = "Test456";
            var guildId02 = "123456";
            var config02 = new DiscordClientConfig(apiKey02, guildId02);

            Assert.Equal(apiKey02, config02.ApiKey);
            Assert.Equal(guildId02, config02.GuildId);
        }
    }
}