namespace DiscordApiClient
{
    /// <summary>
    /// Class for configuration settings of the client
    /// </summary>
    public class DiscordClientConfig
    {
        private readonly string _apiKey;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="apiKey">API key needed for access</param>
        public DiscordClientConfig(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Extended constructur to additionally sét the guild id
        /// </summary>
        /// <param name="apiKey">API key needed for access</param>
        /// <param name="guildId">ID of the guild to access</param>
        public DiscordClientConfig(string apiKey, string guildId) : this(apiKey)
        {
            GuildId = guildId;
        }

        /// <summary>
        /// Property to retrieve the api key
        /// </summary>
        public string ApiKey { get { return _apiKey; } }

        /// <summary>
        /// Optinional property to set the guild id
        /// </summary>
        public string? GuildId { get; set; }
    }
}
