using System.Text.Json.Serialization;

namespace Portfolio.API.Models
{
    public class AppDetailsRoot
    {
        [JsonPropertyName("AppDetails")]
        public SteamData AppDetails { get; set; }
    }

    public class SteamData
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Achievements
    {
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("highlighted")]
        public List<Highlighted> Highlighted { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class ContentDescriptors
    {
        [JsonPropertyName("ids")]
        public List<object> Ids { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("steam_appid")]
        public int? SteamAppid { get; set; }

        [JsonPropertyName("required_age")]
        public int? RequiredAge { get; set; }

        [JsonPropertyName("is_free")]
        public bool? IsFree { get; set; }

        [JsonPropertyName("controller_support")]
        public string ControllerSupport { get; set; }

        [JsonPropertyName("detailed_description")]
        public string DetailedDescription { get; set; }

        [JsonPropertyName("about_the_game")]
        public string AboutTheGame { get; set; }

        [JsonPropertyName("short_description")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("supported_languages")]
        public string SupportedLanguages { get; set; }

        [JsonPropertyName("header_image")]
        public string HeaderImage { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("developers")]
        public List<string> Developers { get; set; }

        [JsonPropertyName("publishers")]
        public List<string> Publishers { get; set; }

        [JsonPropertyName("price_overview")]
        public PriceOverview PriceOverview { get; set; }

        [JsonPropertyName("packages")]
        public List<int?> Packages { get; set; }

        [JsonPropertyName("package_groups")]
        public List<PackageGroup> PackageGroups { get; set; }

        [JsonPropertyName("platforms")]
        public Platforms Platforms { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; }

        [JsonPropertyName("screenshots")]
        public List<Screenshot> Screenshots { get; set; }

        [JsonPropertyName("movies")]
        public List<Movie> Movies { get; set; }

        [JsonPropertyName("achievements")]
        public Achievements Achievements { get; set; }

        [JsonPropertyName("release_date")]
        public ReleaseDate ReleaseDate { get; set; }

        [JsonPropertyName("support_info")]
        public SupportInfo SupportInfo { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("background_raw")]
        public string BackgroundRaw { get; set; }

        [JsonPropertyName("content_descriptors")]
        public ContentDescriptors ContentDescriptors { get; set; }
    }

    public class Genre
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Highlighted
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }
    }

    public class Movie
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("webm")]
        public Webm Webm { get; set; }

        [JsonPropertyName("mp4")]
        public Mp4 Mp4 { get; set; }

        [JsonPropertyName("highlight")]
        public bool? Highlight { get; set; }
    }

    public class Mp4
    {
        [JsonPropertyName("480")]
        public string _480 { get; set; }

        [JsonPropertyName("max")]
        public string Max { get; set; }
    }

    public class PackageGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("selection_text")]
        public string SelectionText { get; set; }

        [JsonPropertyName("save_text")]
        public string SaveText { get; set; }

        [JsonPropertyName("display_type")]
        public int? DisplayType { get; set; }

        [JsonPropertyName("is_recurring_subscription")]
        public string IsRecurringSubscription { get; set; }

        [JsonPropertyName("subs")]
        public List<Sub> Subs { get; set; }
    }

    public class Platforms
    {
        [JsonPropertyName("windows")]
        public bool? Windows { get; set; }

        [JsonPropertyName("mac")]
        public bool? Mac { get; set; }

        [JsonPropertyName("linux")]
        public bool? Linux { get; set; }
    }

    public class PriceOverview
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("initial")]
        public int? Initial { get; set; }

        [JsonPropertyName("final")]
        public int? Final { get; set; }

        [JsonPropertyName("discount_percent")]
        public int? DiscountPercent { get; set; }

        [JsonPropertyName("initial_formatted")]
        public string InitialFormatted { get; set; }

        [JsonPropertyName("final_formatted")]
        public string FinalFormatted { get; set; }
    }

    public class ReleaseDate
    {
        [JsonPropertyName("coming_soon")]
        public bool? ComingSoon { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }
    }

    public class Screenshot
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("path_thumbnail")]
        public string PathThumbnail { get; set; }

        [JsonPropertyName("path_full")]
        public string PathFull { get; set; }
    }

    public class Sub
    {
        [JsonPropertyName("packageid")]
        public int? Packageid { get; set; }

        [JsonPropertyName("percent_savings_text")]
        public string PercentSavingsText { get; set; }

        [JsonPropertyName("percent_savings")]
        public int? PercentSavings { get; set; }

        [JsonPropertyName("option_text")]
        public string OptionText { get; set; }

        [JsonPropertyName("option_description")]
        public string OptionDescription { get; set; }

        [JsonPropertyName("can_get_free_license")]
        public string CanGetFreeLicense { get; set; }

        [JsonPropertyName("is_free_license")]
        public bool? IsFreeLicense { get; set; }

        [JsonPropertyName("price_in_cents_with_discount")]
        public int? PriceInCentsWithDiscount { get; set; }
    }

    public class SupportInfo
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

    public class Webm
    {
        [JsonPropertyName("480")]
        public string _480 { get; set; }

        [JsonPropertyName("max")]
        public string Max { get; set; }
    }
}
