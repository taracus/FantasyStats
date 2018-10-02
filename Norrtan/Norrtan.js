$(document).ready(function () {
    updateToWeek();

});

function updateToWeek() {
    if (typeof selectedTeam != "undefined") {
        console.log("PreSelected team is " + selectedTeam);
    }
    selectedTeam = $('input[name=teamselection]:checked').val();
    selectedPlayer = $('input[name=playerselection]:checked').val();
    console.log("PostSelected team is " + selectedTeam);
    var week = $("#gameWeek").val();
    var teamSort = $("#teamsort").val();
    console.log("Updating to week " + week);
    var weekStats = getWeeklyStats(week, teamSort);
    $("#teamstats").html(weekStats);
    console.log("WTF");
    var playerStats = getFootballPlayerStats(week);
    $("#playerstats").html(playerStats);

    var summary = getWeekSummary(getWeeklyTeamStats(week), getWeeklyPlayerStats(week));
    $("#summary").html(summary);
}

function getWeekSummary(teamStats, playerStats) {
    var chipsMongos = new Array();
    for (var i = 0; i < teamStats.length; i++) {
        if (teamStats[i].Chips != "") {
            chipsMongos.push(teamStats[i]);
        }
    }
    chipsMongo = "undefined";
    if (chipsMongos.length > 0) {
        chipsMongos.sort(compareWeeklyPoints);
        chipsMongoId = chipsMongos[chipsMongos.length - 1].Id;
        chipsMongo = leagueTeams[chipsMongoId].Owner;
    }
    teamStats.sort(compareWeeklyPoints);
    console.log("TeamStats sorted length: " + teamStats.length + " Value: " + teamStats[teamStats.length - 1].Id);
    var lt = leagueTeams[teamStats[teamStats.length - 1].Id];
    var jumboId = teamStats[teamStats.length - 1].Id;
    console.log("LT: " + lt + " Owner: " + lt.Owner);
    var jumbo = lt.Owner;

    teamStats.sort(compareBenchToPoints);
    var fingerToppareJumbo = leagueTeams[teamStats[0].Id].Owner;

    var summary = "<p>Veckans jumbo: " + jumbo + "<a href=\"" + getProfilePic(jumboId) + "\"><img width=\"100\" height=\"100\" src=\"" + getProfilePic(jumboId) +"\" /></a ></p>";
    summary += "<p>Fingertopps-jumbo: " + fingerToppareJumbo + "<a href=\"" + getProfilePic(teamStats[0].Id) + "\"><img width=\"100\" height=\"100\" src=\"" + getProfilePic(teamStats[0].Id) + "\" /></a ></p > ";
    if (chipsMongos.length > 1) {
        summary += "<p>Veckans chips-mongo: " + chipsMongo + "<a href=\"" + getProfilePic(chipsMongoId) + "\"><img width=\"100\" height=\"100\" src=\"" + getProfilePic(chipsMongoId) + "\" /></a ></p>";
    }
    return summary;
}

function getWeeklyTeamStats(week) {
    weeklyStats = new Array();
    for (var i = 0; i < teamWeekly.length; i++) {
        weeklyStats.push(teamWeekly[i].WeeklyPerformance[week]);
    }
    return weeklyStats;
}

function getTeamStats(teamid) {
    for (var i = 0; i < teamWeekly.length; i++) {
        if (teamWeekly[i].Id == teamid) {
            return teamWeekly[i];
        }
    }
}

function getWeeklyStats(week, sort) {
    var weekStats = getWeeklyTeamStats(week);
    var sortFunc = compareWeeklyPoints;
    if (sort == 0) {
        sortFunc = compareWeeklyPoints;
    }
    else if (sort == 1) {
        sortFunc = compareWeeklyPointsBench;
    }
    else if (sort == 2) {
        sortFunc = compareBubbel;
    }
    else if (sort == 3) {
        sortFunc = compareBenchToPoints;
    }
    else if (sort == 4) {
        sortFunc = compareUniqueness;
    }
    else if (sort == 5) {
        sortFunc = compareUniquePlayers;
    }
    weekStats.sort(sortFunc);
    var result = "<table border=\"1\"><tr><th>Namn</th><th>Points</th><th>Bench</th><th>AvgPoints</th><th>P/Avg</th><th>P/Bench</th><th>Unique players</th><th>Uniqueness (low == unique)</th><th>Face</th><th>Chips</th><th>Show picks</th>";
    for (var i = 0; i < weekStats.length; i++) {
        var ws = weekStats[i];

        var benchPerPoint = ws.PointsOnBench / ws.Points;
        if (typeof selectedPlayer != "undefined" && selectedPlayer != null) {
            if (elementIsIn(ws.Picks, selectedPlayer)) {
                result += "<tr bgcolor=\"lime\">";
            }
            else {
                result += "<tr>";
            }
        }
        else {
            result += "<tr>";
        }
        result += "<td>" + leagueTeams[ws.Id].Owner + "</td><td>" + ws.Points + "</td><td>" + ws.PointsOnBench + "</td><td>" + (Math.round(ws.AvgPoints * 100) / 100) + "</td><td>" + (Math.round((ws.Points / ws.AvgPoints) * 100) / 100) + "</td><td>" + (Math.round(benchPerPoint * 100) / 100) + "</td><td>" + ws.NumUniquePlayers + "</td><td>" + ws.PicksInOtherSquads + "</td>";
        result += "<td><a href=\"" + getProfilePic(ws.Id) + "\"> <img width=\"50\" height=\"50\" src=\"" + getProfilePic(ws.Id) + "\" /></a></td>";
        result += "<td>" + ws.Chips + "</td>";
        if (typeof selectedTeam != "undefined" && selectedTeam == ws.Id) {
            result += "<td><input type=\"radio\" checked=\"true\" name=\"teamselection\" onchange =\"updateToWeek()\" class=\"teamselection\" value=\"" + ws.Id + "\" /></td>";
        }
        else {
            result += "<td><input type=\"radio\" name=\"teamselection\" onchange =\"updateToWeek()\" class=\"teamselection\" value=\"" + ws.Id + "\" /></td>";
        }
        result += "</tr>";

    }
    return result;
}

function getWeeklyPlayerStats(week) {

    
    weeklyStats = new Array();
    var week = playersWeekly.StatsPerWeek[week];

    for (var i = 1; i < 539; i++) {
        var currPlayer = week[i];
        if (typeof currPlayer == 'undefined') {
            continue;
        }
        else {
        }
        var player = {};
        player.Name = staticPlayers[currPlayer.Id].Name;

        player.NumTeams = currPlayer.NumTeams;
        player.Benches = currPlayer.NumBenches;
        player.Captain = currPlayer.NumCaptains;
        player.Points = currPlayer.TotalPoints;
        player.Inclusion = (Math.round((currPlayer.NumTeams / 23) * 100) / 100) * 100;
        player.Id = currPlayer.Id;
        player.WeeklyPoints = currPlayer.WeeklyPoints;
        weeklyStats.push(player);
    }
    return weeklyStats;
}

function getFootballPlayerStats(week) {
    var weekStats = getWeeklyPlayerStats(week);
    console.log("Found " + weekStats.length + " players");
    var playerSortFunc = compareNumTeams;
    var playerSort = $("#playersort").val();
    if (playerSort == 1) {
        playerSortFunc = compareNumTeams;
    }
    else if (playerSort == 2) {
        playerSortFunc = comparePlayerWeekPoints;
    } else if (playerSort == 3) {
        playerSortFunc = comparePlayerPoints;
    }
    weekStats.sort(playerSortFunc);
    if (typeof selectedTeam != "undefined") {
        selectedStats = getTeamStats(selectedTeam);
    } else {
        selectedStats = null;
    }
    var result2 = "<table><tr><th>Namn</th><th>Picked</th><th>Benched</th><th>Captain</th><th>Inclusion%</th><th>Last GW Points</th><th>Total Points</th><th>Show teams</th>";
    for (var i = 0; i < weekStats.length; i++) {
        var ws = weekStats[i];
        
        if (selectedStats != null && typeof selectedStats != "undefined") {
            
            if (elementIsIn(selectedStats.WeeklyPerformance[week].Picks, ws.Id)) {
                result2 += "<tr bgcolor=\"lime\">";
            }
            else {
                result2 += "<tr>";
            }
        }
        else {
            result2 += "<tr>";
        }
        result2 += "<td>" + ws.Name + "</td><td>" + ws.NumTeams + "</td><td>" + ws.Benches + "</td><td>" + ws.Captain + "</td><td>" + ws.Inclusion + "%</td><td>"+ws.WeeklyPoints+"</td><td>"+ ws.Points+"</td>";
        

        if (typeof selectedPlayer != "undefined" && selectedPlayer == ws.Id) {
            result2 += "<td><input type=\"radio\" checked=\"true\" name=\"playerselection\" onchange =\"updateToWeek()\" class=\"playerselection\" value=\"" + ws.Id + "\" /></td>";
        }
        else {
            result2 += "<td><input type=\"radio\" name=\"playerselection\" onchange =\"updateToWeek()\" class=\"playerselection\" value=\"" + ws.Id + "\" /></td>";
        }
        result2 += "</tr>";
    }
    result2 += "</table>";
    return result2;
}

function elementIsIn(arr, el) {
    for (var t = 0; t < arr.length; t++) {
        if (arr[t] == el) {
            return true;
        }
        else {
        }
    }
    return false;
}

function getProfilePic(teamId) {
    return "./img/" + teamId + ".jpg";
}

function compareBenchToPoints(a, b) {
    var av, bv;
    if (a.Points != 0) {
        var av = a.PointsOnBench / a.Points;
    }
    else {
        av = 0;
    }

    if (b.Points != 0) {
        var bv = b.PointsOnBench / b.Points;
    }
    else {
        bv = 0;
    }

    if (av < bv) {
        return 1;
    }
    else if (av > bv) {
        return -1;
    }
    else {
        return 0;
    }
}

function compareWeeklyPoints(a, b) {
    if (a.Points < b.Points) {
        return 1;
    }
    else if (a.Points > b.Points) {
        return -1;
    }
    else {
        return 0;
    }

}
function compareUniquePlayers(a, b) {
    if (a.NumUniquePlayers < b.NumUniquePlayers) {
        return 1;
    }
    else if (a.NumUniquePlayers > b.NumUniquePlayers) {
        return -1;
    }
    else {
        return 0;
    }

}


function compareUniqueness(a, b) {
    if (a.PicksInOtherSquads < b.PicksInOtherSquads) {
        return -1;
    }
    else if (a.PicksInOtherSquads > b.PicksInOtherSquads) {
        return 1;
    }
    else {
        return 0;
    }

}

function compareWeeklyPointsBench(a, b) {
    if (a.PointsOnBench < b.PointsOnBench) {
        return 1;
    }
    else if (a.PointsOnBench > b.PointsOnBench) {
        return -1;
    }
    else {
        return 0;
    }
}

function compareBubbel(a, b) {
    var av, bv;
    if (a.AvgPoints != 0) {
        var av = a.Points / a.AvgPoints;
    }
    else {
        av = 0;
    }

    if (b.AvgPoints != 0) {
        var bv = b.Points / b.AvgPoints;
    }
    else {
        bv = 0;
    }
    if (av < bv) {
        return 1;
    }
    else if (av > bv) {
        return -1;
    }
    else {
        return 0;
    }
}

function compareNumTeams(a, b) {
    if (a.NumTeams > b.NumTeams) {
        return -1;
    }
    else if (a.NumTeams < b.NumTeams) {
        return 1;
    }
    else {
        return 0;
    }
}

function comparePlayerPoints(a, b) {
    if (a.Points > b.Points) {
        return -1;
    }
    else if (a.Points < b.Points) {
        return 1;
    }
    return 0;
}

function comparePlayerWeekPoints(a, b) {
    if (a.WeeklyPoints > b.WeeklyPoints) {
        return -1;
    }
    else if (a.WeeklyPoints < b.WeeklyPoints) {
        return 1;
    }
    return 0;
}

function compareCaptain(a, b) {
    if (a.Captain > b.Captain) {
        return 1;
    }
    else if (a.Captain < b.Captain) {
        return -1;
    }
    else {
        return 0;
    }
}
