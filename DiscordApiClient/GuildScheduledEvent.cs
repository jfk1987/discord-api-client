using System.Text.Json.Serialization;

namespace DiscordApiClient
{

    public partial class GuildScheduledEvent
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("guild_id")]
        public string? GuildId { get; set; }

        [JsonPropertyName("channel_id")]
        [JsonInclude]
        public string? ChannelId { get; set; }

        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        [JsonPropertyName("name")]
        [JsonInclude]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("image")]
        public object? Image { get; set; }

        [JsonPropertyName("scheduled_start_time")]
        [JsonInclude]
        public DateTimeOffset? ScheduledStartTime { get; set; }

        [JsonPropertyName("scheduled_end_time")]
        [JsonInclude]
        public DateTimeOffset? ScheduledEndTime { get; set; }

        [JsonPropertyName("privacy_level")]
        [JsonInclude]
        public long? PrivacyLevel { get; set; }

        [JsonPropertyName("status")]
        public long? Status { get; set; }

        [JsonPropertyName("entity_type")]
        [JsonInclude]
        public long? EntityType { get; set; }

        [JsonPropertyName("entity_id")]
        public object? EntityId { get; set; }

        [JsonPropertyName("entity_metadata")]
        public object? EntityMetadata { get; set; }

        [JsonPropertyName("sku_ids")]
        public object[]? SkuIds { get; set; }

        [JsonPropertyName("creator")]
        public Creator? Creator { get; set; }
    }

    public partial class Creator
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("avatar")]
        public object? Avatar { get; set; }

        [JsonPropertyName("discriminator")]
        public string? Discriminator { get; set; }

        [JsonPropertyName("public_flags")]
        public long? PublicFlags { get; set; }

        [JsonPropertyName("bot")]
        public bool? Bot { get; set; }
    }
}
