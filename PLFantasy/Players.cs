// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var staticPlayers = StaticPlayers.FromJson(jsonString);

namespace PLFantasy
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class FootballPlayer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Team { get; set; }
        public long TotalPoints { get; set; }
        public long LastWeekPoints { get; set; }
    }

    public partial class StaticPlayers
    {
        [JsonProperty("phases")]
        public List<Phase> Phases { get; set; }

        [JsonProperty("elements")]
        public List<Element> Elements { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("game-settings")]
        public GameSettings GameSettings { get; set; }

        [JsonProperty("current-event")]
        public long CurrentEvent { get; set; }

        [JsonProperty("total-players")]
        public long TotalPlayers { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("element_types")]
        public List<ElementTypeElement> ElementTypes { get; set; }

        [JsonProperty("last-entry-event")]
        public long LastEntryEvent { get; set; }

        [JsonProperty("stats_options")]
        public List<StatsOption> StatsOptions { get; set; }

        [JsonProperty("next_event_fixtures")]
        public List<NextEventFixture> NextEventFixtures { get; set; }

        [JsonProperty("events")]
        public List<StaticEvent> Events { get; set; }

        [JsonProperty("next-event")]
        public long NextEvent { get; set; }
    }

    public partial class ElementTypeElement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("singular_name")]
        public string SingularName { get; set; }

        [JsonProperty("singular_name_short")]
        public string SingularNameShort { get; set; }

        [JsonProperty("plural_name")]
        public string PluralName { get; set; }

        [JsonProperty("plural_name_short")]
        public string PluralNameShort { get; set; }
    }

    public partial class Element
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("web_name")]
        public string WebName { get; set; }

        [JsonProperty("team_code")]
        public long TeamCode { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("second_name")]
        public string SecondName { get; set; }

        [JsonProperty("squad_number")]
        public long? SquadNumber { get; set; }

        [JsonProperty("news")]
        public string News { get; set; }

        [JsonProperty("now_cost")]
        public long NowCost { get; set; }

        [JsonProperty("news_added")]
        public DateTimeOffset? NewsAdded { get; set; }

        [JsonProperty("chance_of_playing_this_round")]
        public long? ChanceOfPlayingThisRound { get; set; }

        [JsonProperty("chance_of_playing_next_round")]
        public long? ChanceOfPlayingNextRound { get; set; }

        [JsonProperty("value_form")]
        public string ValueForm { get; set; }

        [JsonProperty("value_season")]
        public string ValueSeason { get; set; }

        [JsonProperty("cost_change_start")]
        public long CostChangeStart { get; set; }

        [JsonProperty("cost_change_event")]
        public long CostChangeEvent { get; set; }

        [JsonProperty("cost_change_start_fall")]
        public long CostChangeStartFall { get; set; }

        [JsonProperty("cost_change_event_fall")]
        public long CostChangeEventFall { get; set; }

        [JsonProperty("in_dreamteam")]
        public bool InDreamteam { get; set; }

        [JsonProperty("dreamteam_count")]
        public long DreamteamCount { get; set; }

        [JsonProperty("selected_by_percent")]
        public string SelectedByPercent { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("transfers_out")]
        public long TransfersOut { get; set; }

        [JsonProperty("transfers_in")]
        public long TransfersIn { get; set; }

        [JsonProperty("transfers_out_event")]
        public long TransfersOutEvent { get; set; }

        [JsonProperty("transfers_in_event")]
        public long TransfersInEvent { get; set; }

        [JsonProperty("loans_in")]
        public long LoansIn { get; set; }

        [JsonProperty("loans_out")]
        public long LoansOut { get; set; }

        [JsonProperty("loaned_in")]
        public long LoanedIn { get; set; }

        [JsonProperty("loaned_out")]
        public long LoanedOut { get; set; }

        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        [JsonProperty("event_points")]
        public long EventPoints { get; set; }

        [JsonProperty("points_per_game")]
        public string PointsPerGame { get; set; }

        [JsonProperty("ep_this")]
        public string EpThis { get; set; }

        [JsonProperty("ep_next")]
        public string EpNext { get; set; }

        [JsonProperty("special")]
        public bool Special { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public long GoalsScored { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public long CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public long GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public long OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public long PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public long PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public long YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public long RedCards { get; set; }

        [JsonProperty("saves")]
        public long Saves { get; set; }

        [JsonProperty("bonus")]
        public long Bonus { get; set; }

        [JsonProperty("bps")]
        public long Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("ea_index")]
        public long EaIndex { get; set; }

        [JsonProperty("element_type")]
        public long ElementType { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }
    }

    public partial class StaticEvent
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
        public long? HighestScoringEntry { get; set; }

        [JsonProperty("deadline_time_epoch")]
        public long DeadlineTimeEpoch { get; set; }

        [JsonProperty("deadline_time_game_offset")]
        public long DeadlineTimeGameOffset { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        [JsonProperty("highest_score")]
        public long? HighestScore { get; set; }

        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }

        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }

        [JsonProperty("is_next")]
        public bool IsNext { get; set; }
    }

    public partial class GameSettings
    {
        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("element_type")]
        public Dictionary<string, ElementTypeValue> ElementType { get; set; }
    }

    public partial class ElementTypeValue
    {
        [JsonProperty("scoring_clean_sheets")]
        public long ScoringCleanSheets { get; set; }

        [JsonProperty("squad_min_play")]
        public long SquadMinPlay { get; set; }

        [JsonProperty("bps_clean_sheets")]
        public long BpsCleanSheets { get; set; }

        [JsonProperty("scoring_goals_conceded")]
        public long ScoringGoalsConceded { get; set; }

        [JsonProperty("scoring_goals_scored")]
        public long ScoringGoalsScored { get; set; }

        [JsonProperty("squad_max_play")]
        public long SquadMaxPlay { get; set; }

        [JsonProperty("bps_goals_scored")]
        public long BpsGoalsScored { get; set; }

        [JsonProperty("ui_shirt_specific", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UiShirtSpecific { get; set; }

        [JsonProperty("squad_select")]
        public long SquadSelect { get; set; }

        [JsonProperty("sub_positions_locked", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> SubPositionsLocked { get; set; }
    }

    public partial class Game
    {
        [JsonProperty("scoring_ea_index")]
        public long ScoringEaIndex { get; set; }

        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }

        [JsonProperty("bps_tackles")]
        public long BpsTackles { get; set; }

        [JsonProperty("league_h2h_tiebreak")]
        public string LeagueH2HTiebreak { get; set; }

        [JsonProperty("scoring_long_play")]
        public long ScoringLongPlay { get; set; }

        [JsonProperty("bps_recoveries_limit")]
        public long BpsRecoveriesLimit { get; set; }

        [JsonProperty("facebook_app_id")]
        public string FacebookAppId { get; set; }

        [JsonProperty("bps_tackled")]
        public long BpsTackled { get; set; }

        [JsonProperty("bps_errors_leading_to_goal")]
        public long BpsErrorsLeadingToGoal { get; set; }

        [JsonProperty("bps_yellow_cards")]
        public long BpsYellowCards { get; set; }

        [JsonProperty("ui_el_hide_currency_qi")]
        public bool UiElHideCurrencyQi { get; set; }

        [JsonProperty("scoring_bonus")]
        public long ScoringBonus { get; set; }

        [JsonProperty("transfers_cost")]
        public long TransfersCost { get; set; }

        [JsonProperty("default_formation")]
        public List<List<long>> DefaultFormation { get; set; }

        [JsonProperty("bps_long_play")]
        public long BpsLongPlay { get; set; }

        [JsonProperty("bps_long_play_limit")]
        public long BpsLongPlayLimit { get; set; }

        [JsonProperty("scoring_assists")]
        public long ScoringAssists { get; set; }

        [JsonProperty("scoring_long_play_limit")]
        public long ScoringLongPlayLimit { get; set; }

        [JsonProperty("fifa_league_id")]
        public long FifaLeagueId { get; set; }

        [JsonProperty("league_size_classic_max")]
        public long LeagueSizeClassicMax { get; set; }

        [JsonProperty("scoring_red_cards")]
        public long ScoringRedCards { get; set; }

        [JsonProperty("scoring_creativity")]
        public long ScoringCreativity { get; set; }

        [JsonProperty("game_timezone")]
        public string GameTimezone { get; set; }

        [JsonProperty("static_game_url")]
        public string StaticGameUrl { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("bps_target_missed")]
        public long BpsTargetMissed { get; set; }

        [JsonProperty("bps_penalties_saved")]
        public long BpsPenaltiesSaved { get; set; }

        [JsonProperty("support_email_address")]
        public string SupportEmailAddress { get; set; }

        [JsonProperty("cup_start_event_id")]
        public long CupStartEventId { get; set; }

        [JsonProperty("scoring_penalties_saved")]
        public long ScoringPenaltiesSaved { get; set; }

        [JsonProperty("scoring_threat")]
        public long ScoringThreat { get; set; }

        [JsonProperty("scoring_saves")]
        public long ScoringSaves { get; set; }

        [JsonProperty("league_join_private_max")]
        public long LeagueJoinPrivateMax { get; set; }

        [JsonProperty("scoring_short_play")]
        public long ScoringShortPlay { get; set; }

        [JsonProperty("sys_use_event_live_api")]
        public bool SysUseEventLiveApi { get; set; }

        [JsonProperty("scoring_concede_limit")]
        public long ScoringConcedeLimit { get; set; }

        [JsonProperty("bps_key_passes")]
        public long BpsKeyPasses { get; set; }

        [JsonProperty("bps_clearances_blocks_interceptions")]
        public long BpsClearancesBlocksInterceptions { get; set; }

        [JsonProperty("bps_pass_percentage_90")]
        public long BpsPassPercentage90 { get; set; }

        [JsonProperty("bps_big_chances_missed")]
        public long BpsBigChancesMissed { get; set; }

        [JsonProperty("league_max_ko_rounds_h2h")]
        public long LeagueMaxKoRoundsH2H { get; set; }

        [JsonProperty("bps_open_play_crosses")]
        public long BpsOpenPlayCrosses { get; set; }

        [JsonProperty("league_points_h2h_win")]
        public long LeaguePointsH2HWin { get; set; }

        [JsonProperty("bps_saves")]
        public long BpsSaves { get; set; }

        [JsonProperty("bps_cbi_limit")]
        public long BpsCbiLimit { get; set; }

        [JsonProperty("league_size_h2h_max")]
        public long LeagueSizeH2HMax { get; set; }

        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }

        [JsonProperty("squad_squadplay")]
        public long SquadSquadplay { get; set; }

        [JsonProperty("bps_fouls")]
        public long BpsFouls { get; set; }

        [JsonProperty("squad_squadsize")]
        public long SquadSquadsize { get; set; }

        [JsonProperty("ui_selection_short_team_names")]
        public bool UiSelectionShortTeamNames { get; set; }

        [JsonProperty("transfers_sell_on_fee")]
        public double TransfersSellOnFee { get; set; }

        [JsonProperty("transfers_type")]
        public string TransfersType { get; set; }

        [JsonProperty("scoring_ict_index")]
        public long ScoringIctIndex { get; set; }

        [JsonProperty("bps_pass_percentage_80")]
        public long BpsPassPercentage80 { get; set; }

        [JsonProperty("bps_own_goals")]
        public long BpsOwnGoals { get; set; }

        [JsonProperty("scoring_yellow_cards")]
        public long ScoringYellowCards { get; set; }

        [JsonProperty("bps_pass_percentage_70")]
        public long BpsPassPercentage70 { get; set; }

        [JsonProperty("ui_show_home_away")]
        public bool UiShowHomeAway { get; set; }

        [JsonProperty("ui_el_hide_currency_sy")]
        public bool UiElHideCurrencySy { get; set; }

        [JsonProperty("bps_assists")]
        public long BpsAssists { get; set; }

        [JsonProperty("squad_team_limit")]
        public long SquadTeamLimit { get; set; }

        [JsonProperty("league_points_h2h_draw")]
        public long LeaguePointsH2HDraw { get; set; }

        [JsonProperty("transfers_limit")]
        public long TransfersLimit { get; set; }

        [JsonProperty("bps_dribbles")]
        public long BpsDribbles { get; set; }

        [JsonProperty("bps_offside")]
        public long BpsOffside { get; set; }

        [JsonProperty("sys_cdn_cache_enabled")]
        public bool SysCdnCacheEnabled { get; set; }

        [JsonProperty("currency_multiplier")]
        public long CurrencyMultiplier { get; set; }

        [JsonProperty("bps_red_cards")]
        public long BpsRedCards { get; set; }

        [JsonProperty("bps_winning_goals")]
        public long BpsWinningGoals { get; set; }

        [JsonProperty("league_join_public_max")]
        public long LeagueJoinPublicMax { get; set; }

        [JsonProperty("formations")]
        public Dictionary<string, List<List<long>>> Formations { get; set; }

        [JsonProperty("league_points_h2h_lose")]
        public long LeaguePointsH2HLose { get; set; }

        [JsonProperty("currency_decimal_places")]
        public long CurrencyDecimalPlaces { get; set; }

        [JsonProperty("bps_errors_leading_to_goal_attempt")]
        public long BpsErrorsLeadingToGoalAttempt { get; set; }

        [JsonProperty("ui_selection_price_gap")]
        public long UiSelectionPriceGap { get; set; }

        [JsonProperty("bps_big_chances_created")]
        public long BpsBigChancesCreated { get; set; }

        [JsonProperty("ui_selection_player_limit")]
        public long UiSelectionPlayerLimit { get; set; }

        [JsonProperty("bps_attempted_passes_limit")]
        public long BpsAttemptedPassesLimit { get; set; }

        [JsonProperty("scoring_penalties_missed")]
        public long ScoringPenaltiesMissed { get; set; }

        [JsonProperty("photo_base_url")]
        public string PhotoBaseUrl { get; set; }

        [JsonProperty("scoring_bps")]
        public long ScoringBps { get; set; }

        [JsonProperty("scoring_influence")]
        public long ScoringInfluence { get; set; }

        [JsonProperty("bps_penalties_conceded")]
        public long BpsPenaltiesConceded { get; set; }

        [JsonProperty("scoring_own_goals")]
        public long ScoringOwnGoals { get; set; }

        [JsonProperty("squad_total_spend")]
        public long SquadTotalSpend { get; set; }

        [JsonProperty("bps_short_play")]
        public long BpsShortPlay { get; set; }

        [JsonProperty("ui_element_wrap")]
        public long UiElementWrap { get; set; }

        [JsonProperty("bps_recoveries")]
        public long BpsRecoveries { get; set; }

        [JsonProperty("bps_penalties_missed")]
        public long BpsPenaltiesMissed { get; set; }

        [JsonProperty("scoring_saves_limit")]
        public long ScoringSavesLimit { get; set; }
    }

    public partial class NextEventFixture
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        [JsonProperty("started")]
        public bool Started { get; set; }

        [JsonProperty("event_day")]
        public long EventDay { get; set; }

        [JsonProperty("deadline_time")]
        public DateTimeOffset DeadlineTime { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public DeadlineTimeFormatted DeadlineTimeFormatted { get; set; }

        [JsonProperty("stats")]
        public List<object> Stats { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("kickoff_time")]
        public DateTimeOffset KickoffTime { get; set; }

        [JsonProperty("team_h_score")]
        public object TeamHScore { get; set; }

        [JsonProperty("team_a_score")]
        public object TeamAScore { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        [JsonProperty("finished_provisional")]
        public bool FinishedProvisional { get; set; }

        [JsonProperty("event")]
        public long Event { get; set; }

        [JsonProperty("team_a")]
        public long TeamA { get; set; }

        [JsonProperty("team_h")]
        public long TeamH { get; set; }
    }

    public partial class Phase
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_winners")]
        public long NumWinners { get; set; }

        [JsonProperty("start_event")]
        public long StartEvent { get; set; }

        [JsonProperty("stop_event")]
        public long StopEvent { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("headings")]
        public List<Heading> Headings { get; set; }

        [JsonProperty("categories")]
        public object Categories { get; set; }
    }

    public partial class Heading
    {
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("abbr")]
        public object Abbr { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public partial class StatsOption
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("current_event_fixture")]
        public List<TEventFixture> CurrentEventFixture { get; set; }

        [JsonProperty("next_event_fixture")]
        public List<TEventFixture> NextEventFixture { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("strength")]
        public long Strength { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("played")]
        public long Played { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }

        [JsonProperty("loss")]
        public long Loss { get; set; }

        [JsonProperty("draw")]
        public long Draw { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("form")]
        public object Form { get; set; }

        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        [JsonProperty("strength_overall_home")]
        public long StrengthOverallHome { get; set; }

        [JsonProperty("strength_overall_away")]
        public long StrengthOverallAway { get; set; }

        [JsonProperty("strength_attack_home")]
        public long StrengthAttackHome { get; set; }

        [JsonProperty("strength_attack_away")]
        public long StrengthAttackAway { get; set; }

        [JsonProperty("strength_defence_home")]
        public long StrengthDefenceHome { get; set; }

        [JsonProperty("strength_defence_away")]
        public long StrengthDefenceAway { get; set; }

        [JsonProperty("team_division")]
        public long TeamDivision { get; set; }
    }

    public partial class TEventFixture
    {
        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("event_day")]
        public long EventDay { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("opponent")]
        public long Opponent { get; set; }
    }

    public enum Status { A, D, I, N, S, U };

    public enum DeadlineTimeFormatted { The29Sep1130 };

    public partial class StaticPlayers
    {
        public static StaticPlayers FromJson(string json) => JsonConvert.DeserializeObject<StaticPlayers>(json, StaticConverter.Settings);
    }

    public static class StaticSerialize
    {
        public static string ToJson(this StaticPlayers self) => JsonConvert.SerializeObject(self, StaticConverter.Settings);
    }

    internal static class StaticConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                StatusConverter.Singleton,
                DeadlineTimeFormattedConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "a":
                return Status.A;
                case "d":
                return Status.D;
                case "i":
                return Status.I;
                case "n":
                return Status.N;
                case "s":
                return Status.S;
                case "u":
                return Status.U;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.A:
                serializer.Serialize(writer, "a");
                return;
                case Status.D:
                serializer.Serialize(writer, "d");
                return;
                case Status.I:
                serializer.Serialize(writer, "i");
                return;
                case Status.N:
                serializer.Serialize(writer, "n");
                return;
                case Status.S:
                serializer.Serialize(writer, "s");
                return;
                case Status.U:
                serializer.Serialize(writer, "u");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class DeadlineTimeFormattedConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DeadlineTimeFormatted) || t == typeof(DeadlineTimeFormatted?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (true || value == "29 Sep 11:30")
            {
                return DeadlineTimeFormatted.The29Sep1130;
            }
            throw new Exception("Cannot unmarshal type DeadlineTimeFormatted");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DeadlineTimeFormatted)untypedValue;
            if (value == DeadlineTimeFormatted.The29Sep1130)
            {
                serializer.Serialize(writer, "29 Sep 11:30");
                return;
            }
            throw new Exception("Cannot marshal type DeadlineTimeFormatted");
        }

        public static readonly DeadlineTimeFormattedConverter Singleton = new DeadlineTimeFormattedConverter();
    }
}
