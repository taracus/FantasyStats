using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            int currWeek = 7;
            var parser = new Parser();
            var statics = parser.GetStaticPlayers();
            
            Dictionary<long, FootballPlayer> players = new Dictionary<long, FootballPlayer>();
            Dictionary<long, string> teams = new Dictionary<long, string>();
            foreach(var player in statics.Elements)
            {
                FootballPlayer fp = new FootballPlayer();
                fp.Name = player.FirstName + " " + player.SecondName;
                fp.Id = player.Id;
                fp.TotalPoints = player.TotalPoints;
                fp.Team = player.Team;
                fp.LastWeekPoints = player.EventPoints;
                
                players.Add(player.Id, fp);
            }

            foreach(var team in statics.Teams)
            {
                teams.Add(team.Id, team.Name);
            }
            var playerJson = JsonConvert.SerializeObject(players);
            var teamJson = JsonConvert.SerializeObject(teams);
            File.WriteAllText("players.js", "staticPlayers = "+playerJson+";");
            File.WriteAllText("teams.js", "staticTeams = "+ teamJson+";");
            var plFantasy = parser.GetLeague();
            Dictionary<long, LeagueTeam> leagueTeams = new Dictionary<long, LeagueTeam>();
            foreach(var team in plFantasy.Standings.Results)
            {
                var t = new LeagueTeam();
                t.Id = team.Entry;
                t.TeamName = team.EntryName;
                t.Owner = team.PlayerName;
                leagueTeams.Add(t.Id, t);
            }
            var leagueTeamJson = JsonConvert.SerializeObject(leagueTeams);
            File.WriteAllText("leagueteams.js", "leagueTeams = " + leagueTeamJson+";");
            List<TeamPerformance> teamPerformance = new List<TeamPerformance>();

            PlayerPerformance pp = new PlayerPerformance();
            pp.StatsPerWeek = new Dictionary<int, Dictionary<long, PlayerStatistics>>();

            Dictionary<long, PlayerStatistics> playerStats = null;
            foreach (var idAndTeam in leagueTeams)
            {
                TeamPerformance tp = new TeamPerformance();
                tp.Id = idAndTeam.Key;
                tp.Name = idAndTeam.Value.Owner;
                tp.WeeklyPerformance = new Dictionary<int, TeamWeekPerformance>();
                long totalPoints = 0;
                for (int i = 1; i <= currWeek; i++)
                {
                    if (!pp.StatsPerWeek.TryGetValue(i, out playerStats))
                    {
                        playerStats = new Dictionary<long, PlayerStatistics>();
                        pp.StatsPerWeek.Add(i, playerStats);
                    }
                    var weekInfo = parser.GetTeamInfo(tp.Id, i);
                    TeamWeekPerformance wp = new TeamWeekPerformance();
                    wp.Picks = new List<long>();
                    wp.Id = idAndTeam.Key;
                    wp.Points = weekInfo.EntryHistory.Points;
                    wp.PointsOnBench = weekInfo.EntryHistory.PointsOnBench;
                    wp.Chips = weekInfo.ActiveChip;
                    if (i > 1)
                        wp.AvgPoints = totalPoints / (double)(i-1);
                    tp.WeeklyPerformance.Add(i, wp);
                    PlayerStatistics ps = null;
                    double avgTeamPoints = 0;

                    foreach(var pick in weekInfo.Picks)
                    {
                        if (!playerStats.TryGetValue(pick.Element, out ps))
                        {
                            FootballPlayer fp = players[pick.Element];
                            ps = new PlayerStatistics();
                            ps.Id = pick.Element;
                            ps.TotalPoints = fp.TotalPoints;
                            ps.WeeklyPoints = fp.LastWeekPoints;
                            playerStats.Add(pick.Element, ps);
                        }
                        
                        if (pick.IsCaptain)
                        {
                            ps.NumCaptains++;
                        }
                        if (pick.IsViceCaptain)
                        {
                            ps.NumViceCaptain++;
                        }
                        if (pick.Position > 11)
                        {
                            ps.NumBenches++;
                        }
                        else
                        {
                            wp.Picks.Add(pick.Element);
                            ps.NumTeams++;
                            avgTeamPoints += ps.TotalPoints;
                        }
                        
                    }
                    totalPoints += wp.Points;
                }
                teamPerformance.Add(tp);


            }
            for (int i = 1; i <= currWeek; i++)
            {
                var pStats = pp.StatsPerWeek[i];
                foreach (var idAndTeam in leagueTeams)
                {
                    TeamPerformance tp = teamPerformance.Where(p => p.Id == idAndTeam.Key).Single();
                    var weekInfo = parser.GetTeamInfo(idAndTeam.Key, i);
                    int numCopiesOfPlayers = 0;
                    int numUniquePlayers = 0;
                    foreach (var pick in weekInfo.Picks)
                    {
                        PlayerStatistics ps = pStats[pick.Element];
                        numCopiesOfPlayers += (ps.NumTeams - 1);
                        if (ps.NumTeams == 1)
                        {
                            numUniquePlayers++;
                        }
                    }
                    tp.WeeklyPerformance[i].NumUniquePlayers = numUniquePlayers;
                    tp.WeeklyPerformance[i].PicksInOtherSquads = numCopiesOfPlayers;
                }
            }
            string teamWeekJson = JsonConvert.SerializeObject(teamPerformance);
            File.WriteAllText("teamweekly.js", "teamWeekly = " +teamWeekJson+";");

            string playerWeekJson = JsonConvert.SerializeObject(pp);
            File.WriteAllText("playerweekly.js", "playersWeekly = " + playerWeekJson + ";");
            
        }
    }
}
