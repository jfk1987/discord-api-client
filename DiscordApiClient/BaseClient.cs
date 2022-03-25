namespace DiscordApiClient
{
    /// <summary>
    /// Base client class for initialization and main logic
    /// </summary>
    public partial class DiscordClient
    {
        DiscordClientConfig _config;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="config">Configuration object</param>
        public DiscordClient(DiscordClientConfig config)
        {
            _config = config;
        }
    }
}
