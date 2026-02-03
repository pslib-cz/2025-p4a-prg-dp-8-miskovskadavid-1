namespace Fasade.Subsystems;

public class CharacterSystem
{
    public void InitializeCharacters(List<string> characterIds)
    {
        Console.WriteLine($"[CharacterSystem] Inicializuji {characterIds.Count} postav...");
        foreach (var id in characterIds)
        {
            Console.WriteLine($"  - Postava {id} pøipravena");
        }
    }

    public void SetPlayerStartPosition(float x, float y, float z)
    {
        Console.WriteLine($"[CharacterSystem] Nastavuji pozici hráèe na [{x}, {y}, {z}]");
    }
}