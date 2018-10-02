using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PLFantasy
{
    public class Parser
    {
        private long LeagueId;

        private string m_LeagueUrl = "https://fantasy.premierleague.com/drf/leagues-classic-standings/{0}?phase=1&le-page=1&ls-page=1";
        private string m_TeamInfoUrl = "https://fantasy.premierleague.com/drf/entry/{0}/event/{1}/picks";
        private string m_HistoryUrl = "https://fantasy.premierleague.com/drf/entry/{0}/history";
        private string m_StaticUrl = "https://fantasy.premierleague.com/drf/bootstrap-static";

       private DateTime m_LastCall = DateTime.MinValue;
        private TimeSpan m_MinCallDiff = TimeSpan.FromSeconds(2);
        public Parser()
        {
            LeagueId = long.Parse(ConfigurationManager.AppSettings["leagueId"]);
        }
        public FantasyLeague GetLeague()
        {
            string url = string.Format(m_LeagueUrl, LeagueId);
            string leagueJson = DownloadString(url);
            return FantasyLeague.FromJson(leagueJson);
        }

        public TeamWeekInfo GetTeamInfo(long teamId, int week)
        {
            string url = string.Format(m_TeamInfoUrl, teamId, week);
            string teamJson = DownloadString(url);
            return TeamWeekInfo.FromJson(teamJson);
        }

        public TeamHistory GetHistory(long teamId)
        {
            string url = string.Format(m_HistoryUrl, teamId);
            string historyJson = DownloadString(url);
            return TeamHistory.FromJson(historyJson);
        }

        public StaticPlayers GetStaticPlayers()
        {
            string staticJson = DownloadString(m_StaticUrl);
            return StaticPlayers.FromJson(staticJson);
        }
        private string DownloadString(string url)
        {
            var waitedTime = DateTime.UtcNow - m_LastCall;
            if (waitedTime < m_MinCallDiff)
            {
                Thread.Sleep((int)m_MinCallDiff.TotalMilliseconds - (int)waitedTime.TotalMilliseconds);
            }
            using (WebClient client = new WebClient())
            {
                string cString = GetCookieString();
                //client.Headers.Add(HttpRequestHeader.Cookie, cString);
                //client.Headers.Add("X-Requested-With", "XMLHttpRequest");
                client.Headers.Add(HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                client.Headers.Add(HttpRequestHeader.Host, "fantasy.premierleague.com");
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.92 Safari/537.36");
                
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(url);
            }
        }

        private string GetCookieString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
