// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var teamHistory = TeamHistory.FromJson(jsonString);

namespace PLFantasy
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TeamHistory
    {
        [JsonProperty("chips")]
        public List<object> Chips { get; set; }

        [JsonProperty("entry")]
        public Entry Entry { get; set; }

        [JsonProperty("leagues")]
        public Leagues Leagues { get; set; }

        [JsonProperty("season")]
        public List<Season> Season { get; set; }

        [JsonProperty("history")]
        public List<History> History { get; set; }
    }

    public partial class Entry
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("player_first_name")]
        public string PlayerFirstName { get; set; }

        [JsonProperty("player_last_name")]
        public string PlayerLastName { get; set; }

        [JsonProperty("player_region_id")]
        public long PlayerRegionId { get; set; }

        [JsonProperty("player_region_name")]
        public string PlayerRegionName { get; set; }

        [JsonProperty("player_region_short_iso")]
        public string PlayerRegionShortIso { get; set; }

        [JsonProperty("summary_overall_points")]
        public long SummaryOverallPoints { get; set; }

        [JsonProperty("summary_overall_rank")]
        public long SummaryOverallRank { get; set; }

        [JsonProperty("summary_event_points")]
        public long SummaryEventPoints { get; set; }

        [JsonProperty("summary_event_rank")]
        public long SummaryEventRank { get; set; }

        [JsonProperty("joined_seconds")]
        public long JoinedSeconds { get; set; }

        [JsonProperty("current_event")]
        public long CurrentEvent { get; set; }

        [JsonProperty("total_transfers")]
        public long TotalTransfers { get; set; }

        [JsonProperty("total_loans")]
        public long TotalLoans { get; set; }

        [JsonProperty("total_loans_active")]
        public long TotalLoansActive { get; set; }

        [JsonProperty("transfers_or_loans")]
        public string TransfersOrLoans { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("email")]
        public bool Email { get; set; }

        [JsonProperty("joined_time")]
        public DateTimeOffset JoinedTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bank")]
        public long Bank { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("kit")]
        public object Kit { get; set; }

        [JsonProperty("event_transfers")]
        public long EventTransfers { get; set; }

        [JsonProperty("event_transfers_cost")]
        public long EventTransfersCost { get; set; }

        [JsonProperty("extra_free_transfers")]
        public long ExtraFreeTransfers { get; set; }

        [JsonProperty("strategy")]
        public object Strategy { get; set; }

        [JsonProperty("favourite_team")]
        public object FavouriteTeam { get; set; }

        [JsonProperty("started_event")]
        public long StartedEvent { get; set; }

        [JsonProperty("player")]
        public long Player { get; set; }
    }

    public partial class History
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("movement")]
        public string Movement { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("rank_sort")]
        public long RankSort { get; set; }

        [JsonProperty("overall_rank")]
        public long OverallRank { get; set; }

        [JsonProperty("targets")]
        public object Targets { get; set; }

        [JsonProperty("event_transfers")]
        public long EventTransfers { get; set; }

        [JsonProperty("event_transfers_cost")]
        public long EventTransfersCost { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("points_on_bench")]
        public long PointsOnBench { get; set; }

        [JsonProperty("bank")]
        public long Bank { get; set; }

        [JsonProperty("entry")]
        public long Entry { get; set; }

        [JsonProperty("event")]
        public long Event { get; set; }
    }

    public partial class Leagues
    {
        [JsonProperty("cup")]
        public List<object> Cup { get; set; }

        [JsonProperty("h2h")]
        public List<object> H2H { get; set; }

        [JsonProperty("classic")]
        public List<Classic> Classic { get; set; }
    }

    public partial class Classic
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("entry_rank")]
        public long EntryRank { get; set; }

        [JsonProperty("entry_last_rank")]
        public long EntryLastRank { get; set; }

        [JsonProperty("entry_movement")]
        public string EntryMovement { get; set; }

        [JsonProperty("entry_change")]
        public long? EntryChange { get; set; }

        [JsonProperty("entry_can_leave")]
        public bool EntryCanLeave { get; set; }

        [JsonProperty("entry_can_admin")]
        public bool EntryCanAdmin { get; set; }

        [JsonProperty("entry_can_invite")]
        public bool EntryCanInvite { get; set; }

        [JsonProperty("entry_can_forum")]
        public bool EntryCanForum { get; set; }

        [JsonProperty("entry_code")]
        public object EntryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("forum_disabled")]
        public bool ForumDisabled { get; set; }

        [JsonProperty("make_code_public")]
        public bool MakeCodePublic { get; set; }

        [JsonProperty("rank")]
        public object Rank { get; set; }

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("league_type")]
        public string LeagueType { get; set; }

        [JsonProperty("_scoring")]
        public string Scoring { get; set; }

        [JsonProperty("reprocess_standings")]
        public bool ReprocessStandings { get; set; }

        [JsonProperty("admin_entry")]
        public long? AdminEntry { get; set; }

        [JsonProperty("start_event")]
        public long StartEvent { get; set; }
    }

    public partial class Season
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("season")]
        public long SeasonSeason { get; set; }

        [JsonProperty("player")]
        public long Player { get; set; }
    }

    public partial class TeamHistory
    {
        public static TeamHistory FromJson(string json) => JsonConvert.DeserializeObject<TeamHistory>(json, HistoryConverter.Settings);
    }

    public static class HistorySerialize
    {
        public static string ToJson(this TeamHistory self) => JsonConvert.SerializeObject(self, HistoryConverter.Settings);
    }

    internal static class HistoryConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
