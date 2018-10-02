// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var teamWeekInfo = TeamWeekInfo.FromJson(jsonString);

namespace PLFantasy
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TeamWeekInfo
    {
        [JsonProperty("active_chip")]
        public string ActiveChip { get; set; }

        [JsonProperty("automatic_subs")]
        public List<AutomaticSub> AutomaticSubs { get; set; }

        [JsonProperty("entry_history")]
        public EntryHistory EntryHistory { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("picks")]
        public List<Pick> Picks { get; set; }
    }

    public partial class AutomaticSub
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("element_in")]
        public long ElementIn { get; set; }

        [JsonProperty("element_out")]
        public long ElementOut { get; set; }

        [JsonProperty("entry")]
        public long Entry { get; set; }

        [JsonProperty("event")]
        public long Event { get; set; }
    }

    public partial class EntryHistory
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

    public partial class Event
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deadline_time")]
        public DateTimeOffset DeadlineTime { get; set; }

        [JsonProperty("average_entry_score")]
        public long AverageEntryScore { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("data_checked")]
        public bool DataChecked { get; set; }

        [JsonProperty("highest_scoring_entry")]
        public long HighestScoringEntry { get; set; }

        [JsonProperty("deadline_time_epoch")]
        public long DeadlineTimeEpoch { get; set; }

        [JsonProperty("deadline_time_game_offset")]
        public long DeadlineTimeGameOffset { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        [JsonProperty("highest_score")]
        public long HighestScore { get; set; }

        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }

        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }

        [JsonProperty("is_next")]
        public bool IsNext { get; set; }
    }

    public partial class Pick
    {
        [JsonProperty("element")]
        public long Element { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("is_captain")]
        public bool IsCaptain { get; set; }

        [JsonProperty("is_vice_captain")]
        public bool IsViceCaptain { get; set; }

        [JsonProperty("multiplier")]
        public long Multiplier { get; set; }
    }

    public partial class TeamWeekInfo
    {
        public static TeamWeekInfo FromJson(string json) => JsonConvert.DeserializeObject<TeamWeekInfo>(json, TeamConverter.Settings);
    }

    public static class TeamSerialize
    {
        public static string ToJson(this TeamWeekInfo self) => JsonConvert.SerializeObject(self, TeamConverter.Settings);
    }

    internal static class TeamConverter
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

