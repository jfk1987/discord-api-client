﻿namespace DiscordApiClient
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

            return null;
        }

        private void CheckGuildId(ref string guildId)
        {
            if(guildId == null)
            {
                guildId= _config.GuildId;
            }
        }

    }
}
