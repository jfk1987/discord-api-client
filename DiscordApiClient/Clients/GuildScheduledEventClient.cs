using DiscordApiClient.Models.GuildScheduledEvent;

namespace DiscordApiClient.Clients
{
    public partial class DiscordClient
    {
        public async Task<List<GuildScheduledEvent>> ListGuildScheduledEvents(string guildId = null)
        {
            CheckGuildId(ref guildId);

            string path = $"/guilds/{guildId}/scheduled-events";

            var request = new RestRequest
            {
                Path = path
            };

            var response = await _client.GetRequestAsync(request);

            return Deserialize<List<GuildScheduledEvent>>(response.Body);
        }

        public async Task<GuildScheduledEvent> CreateGuildScheduledEventAsync(GuildScheduledEvent newEvent, string guildId = null)
        {
            CheckGuildId(ref guildId);

            string path = $"/guilds/{guildId}/scheduled-events";

            var request = new RestRequest
            {
                Body = Serialize(newEvent),
                Path = path
            };

            var response = await _client.GetRequestAsync(request);

            return Deserialize<GuildScheduledEvent>(response.Body);
        }


        private void CheckGuildId(ref string guildId)
        {
            if(guildId == null)
            {
                guildId= _config.GuildId;
            }

            if(guildId == null)
            {
                throw new GuildScheduledEventException("No guild id transmitted!");
            }
        }

    }
}
