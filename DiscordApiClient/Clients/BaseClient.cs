using System.Text.Json;

namespace DiscordApiClient.Clients
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
        private readonly RestClient _client;

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
            _client = new RestClient(config);
        }

        public T Deserialize<T>(string data)
        {
            var deserializedObject = JsonSerializer.Deserialize<T>(data);

            return deserializedObject;
        }

        public string Serialize<T>(T data)
        {
            var serializedText = JsonSerializer.Serialize(data);

            return serializedText;
        }
    }
}
