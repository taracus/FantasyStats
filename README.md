# FantasyStats
Premiere League Fantasy League Statistics builder.

Small project I did to create some weekly statistics for mine and my friends PL-fantasy league.
There are 2 parts of the project:
1. PLFantasy
- This is a normal windows console-application that downloads statistics and creates .js files that are used by the Norrtan project
2. Norrtan
- Really just Index.html + jquery + .js-files from PLFantasy output.
- Simple JS-based html-page that displays some weekly statistics.

How to use:
1. Open the file PLFantasy/bin/Debug/PLFantasy.exe.config and change the leagueId to the leagueId of your choice.
2. Run PLFantasy.exe
3. Copy all .js files from the output-directory to the Norrtan/ directory.
4. Open Index.html in a browser of your choice
5. (Optional) Add images in the Norrtan/img/ directory named [teamId].jpg for each team to make images work.


PS. This has only been used on my own league which has 20 something teams, if there are more than one page of teams in your league this probably wont work.
DS
