using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFantasy
{
    public class TeamWeekPick
    {
        public List<PlayerPick> Picks { get; set; }
    }

    public class PlayerPick
    {
        public long Id { get; set; }
        public bool Captain { get; set; }
        public bool ViceCaptain { get; set; }
        public bool OnBench { get; set; }

    }
}
