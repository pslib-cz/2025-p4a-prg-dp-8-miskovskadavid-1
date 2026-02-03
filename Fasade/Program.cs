using Fasade;

Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║   FACADE PATTERN - Herní mise Demo   ║");
Console.WriteLine("╔═══════════════════════════════════════╗\n");

var gameFacade = new GameMissionFacade();

gameFacade.StartMission("Záchrana vesnice");

Console.WriteLine("\n" + new string('─', 50) + "\n");

gameFacade.StartTutorialMission("První kroky");

Console.WriteLine("\n" + new string('─', 50) + "\n");

Console.WriteLine("🔧 POKROČILÉ POUŽITÍ - Vlastní konfigurace:\n");

gameFacade.MapLoader.LoadMapData("Boss Arena", difficulty: 5);
gameFacade.CharacterSystem.InitializeCharacters(new List<string> { "Player", "Boss_Dragon" });
gameFacade.CharacterSystem.SetPlayerStartPosition(10, 5, 0);
gameFacade.SoundEngine.LoadAmbientMusic("boss_fight");
gameFacade.SoundEngine.PlaySoundEffects("intense", volume: 1.0);
gameFacade.HUDManager.SetupHUD(theme: "red", showMinimap: false, showHealthBar: true);

Console.WriteLine("\n✅ Vlastní konfigurace dokončena!\n");

Console.WriteLine("\n" + new string('─', 50) + "\n");

gameFacade.QuickTestMission("Debug Level");

Console.WriteLine("\n╔═══════════════════════════════════════╗");
Console.WriteLine("║          Demo ukončeno ✓              ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
