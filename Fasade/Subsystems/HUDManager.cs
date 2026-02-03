namespace Fasade.Subsystems;

public class HUDManager
{
    public void SetupHUD(string theme, bool showMinimap, bool showHealthBar)
    {
        Console.WriteLine($"[HUDManager] Nastavuji HUD - téma: {theme}");
        Console.WriteLine($"  Minimapa: {(showMinimap ? "Zapnuta" : "Vypnuta")}");
        Console.WriteLine($"  Ukazatel zdraví: {(showHealthBar ? "Zapnut" : "Vypnut")}");
    }

    public void EnableTutorialMode()
    {
        Console.WriteLine("[HUDManager] Tutorial mode aktivován");
    }
}