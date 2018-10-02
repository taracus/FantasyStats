using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFantasy
{
    public class TeamPerformance
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, TeamWeekPerformance> WeeklyPerformance { get; set; }
    }

    public class TeamWeekPerformance
    {
        public long Id { get; set; }
        public long Points { get; set; }
        public long PointsOnBench { get; set; }
        public double AvgPoints { get; set; }
        public double AvgTeamPoints { get; set; }
        public int NumUniquePlayers { get; set; }
        public int PicksInOtherSquads { get; set; }
        public List<long> Picks { get; set; }
        public string Chips { get; set; }
    }

    public class PlayerPerformance
    {
        public Dictionary<int, Dictionary<long, PlayerStatistics>> StatsPerWeek { get; set; }
    }

    public class PlayerStatistics
    {
        public long Id { get; set; }
        public int NumTeams { get; set; }
        public int NumBenches { get; set; }
        public int NumCaptains { get; set; }
        public int NumViceCaptain { get; set; }
        public long WeeklyPoints { get; set; }
        public long TotalPoints { get; set; }

    }
}
