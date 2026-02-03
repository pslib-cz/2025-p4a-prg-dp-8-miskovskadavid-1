using Fasade.Subsystems;

namespace Fasade;

public class GameMissionFacade
{
    public MapLoader MapLoader { get; }
    public CharacterSystem CharacterSystem { get; }
    public InventoryChecker InventoryChecker { get; }
    public SoundEngine SoundEngine { get; }
    public HUDManager HUDManager { get; }

    public GameMissionFacade()
    {
        MapLoader = new MapLoader();
        CharacterSystem = new CharacterSystem();
        InventoryChecker = new InventoryChecker();
        SoundEngine = new SoundEngine();
        HUDManager = new HUDManager();
    }

    public void StartMission(string missionName)
    {
        Console.WriteLine($"\n═══════════════════════════════════════");
        Console.WriteLine($"  🎮 SPOUŠTÍM MISI: {missionName}");
        Console.WriteLine($"═══════════════════════════════════════\n");

        try
        {
            MapLoader.LoadMapData(missionName, difficulty: 2);
            
            var characters = new List<string> { "Player", "NPC_Guard", "NPC_Merchant" };
            CharacterSystem.InitializeCharacters(characters);
            CharacterSystem.SetPlayerStartPosition(0, 0, 0);
            
            InventoryChecker.ValidateInventory();
            InventoryChecker.PrepareStartingItems("combat");
            
            SoundEngine.LoadAmbientMusic("epic_battle");
            SoundEngine.PlaySoundEffects("default", volume: 0.7);
            
            HUDManager.SetupHUD(theme: "dark", showMinimap: true, showHealthBar: true);

            Console.WriteLine($"\n✅ Mise '{missionName}' úspěšně spuštěna!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Chyba při spouštění mise: {ex.Message}\n");
            throw;
        }
    }

    public void StartTutorialMission(string missionName)
    {
        Console.WriteLine($"\n🎓 Spouštím tutoriál pro misi: {missionName}\n");
        
        MapLoader.LoadMapData(missionName, difficulty: 1);
        CharacterSystem.InitializeCharacters(new List<string> { "Player" });
        InventoryChecker.PrepareStartingItems("tutorial");
        SoundEngine.PlaySoundEffects("tutorial", volume: 0.5);
        HUDManager.SetupHUD(theme: "light", showMinimap: true, showHealthBar: true);
        HUDManager.EnableTutorialMode();
        
        Console.WriteLine("✅ Tutoriál připraven!\n");
    }

    public void QuickTestMission(string missionName)
    {
        Console.WriteLine($"\n⚡ Rychlý test mise: {missionName}\n");
        
        MapLoader.LoadMapData(missionName, difficulty: 1);
        CharacterSystem.InitializeCharacters(new List<string> { "Player" });
        HUDManager.SetupHUD(theme: "debug", showMinimap: false, showHealthBar: true);
        
        Console.WriteLine("✅ Test mise připraven!\n");
    }
}