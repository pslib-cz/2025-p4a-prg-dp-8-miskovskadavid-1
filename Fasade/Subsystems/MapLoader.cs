namespace Fasade.Subsystems;

public class MapLoader
{
    public void LoadMapData(string mapName, int difficulty)
    {
        Console.WriteLine($"[MapLoader] Naèítám mapu '{mapName}' s obtížností {difficulty}...");
        Thread.Sleep(300);
        Console.WriteLine("[MapLoader] Mapa úspìšnì naètena!");
    }

    public bool VerifyMapIntegrity(string mapName)
    {
        Console.WriteLine($"[MapLoader] Kontroluji integritu mapy '{mapName}'...");
        return true;
    }
}