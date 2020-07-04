using System;
using System.Collections.Generic;
using static System.Console;

class GameInsults : Game
{
    public override string GameName => "The Game of Insults";

    public override string GameRules => "The rules are very simple - press the button of your choice to generate an insult:\n" +
            "[1] Insult the opponent \n[2] Insult the opponent's mother \n[3] Insult the opponents kid\n" +
            "and then press Enter." +
            "\n\nAfter both players have chosen, the winner is determined based on the number of points assigned to each insult phrase. " +
            "After each game the application will ask the players if they want to continue, " +
            "and if the player reponds with anything else than [y]es, " +
            $"the game ends and presents the record of the last up to {gamesRecord.gamesRecordSize} games.\n\n" +
            "Have fun!\n";

    protected override string ChoosePhrase => "Which member of the opponent's family do you want to insult?";

    protected override Dictionary<string, string> InputTable => new Dictionary<string, string>()
        {
            {"1", "Opponent"},
            {"2", "Mother"},
            {"3", "Kid"}
        };

    protected override string DetermineWinner()
    {
        WriteLine("Halo!");
        return "Halo";
    }
}