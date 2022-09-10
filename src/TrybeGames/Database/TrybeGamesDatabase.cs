namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // implementar
        var ListGames = from game in Games
        where game.DeveloperStudio == gameStudio.Id
        select game;

        return ListGames.ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        var ListPlayer = from game in Games
        where game.Players.Contains(player.Id)
        select game;

        return ListPlayer.ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        var result = from game in Games
        where playerEntry.GamesOwned.Contains(game.Id)
        select game;

        return result.ToList();
    }
}
