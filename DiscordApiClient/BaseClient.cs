namespace DiscordApiClient
{
    /// <summary>
    /// Base client class for initialization and main logic
    /// </summary>
    public partial class DiscordClient
    {
        /// <summary>
        /// Private property to hold the configuration
        /// </summary>
        private readonly DiscordClientConfig _config;

        /// <summary>
        /// Public property to access the configuration
        /// </summary>
        public DiscordClientConfig Config 
        { 
            get => _config;
        }

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
