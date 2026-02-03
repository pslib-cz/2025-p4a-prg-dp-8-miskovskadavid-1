namespace Fasade.Subsystems;

public class InventoryChecker
{
    public int ValidateInventory()
    {
        Console.WriteLine("[InventoryChecker] Validuji inventáø...");
        Console.WriteLine("[InventoryChecker] Inventáø v poøádku - 15 položek");
        return 15;
    }

    public void PrepareStartingItems(string missionType)
    {
        Console.WriteLine($"[InventoryChecker] Pøipravuji startovní položky pro misi typu '{missionType}'");
    }
}