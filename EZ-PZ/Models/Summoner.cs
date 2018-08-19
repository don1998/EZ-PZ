using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZ_PZ.Models
{
    public class Summoner
    {
        public String profileIcon { get; set; }

        public String summonerName { get; set; }

        public long summonerLevel { get; set; }

        public long revisionDate { get; set; }

        public long summonerId { get; set; }

        public long accountId { get; set; }


        public Summoner(String profileIcon, string summonerName, long summonerLevel)
        {
            this.profileIcon = profileIcon;
            this.summonerName = summonerName;
            this.summonerLevel = summonerLevel;
            /*this.revisionDate = revisionDate;
            this.summonerId = summonerId;
            this.accountId = accountId;*/
        }
    }
}