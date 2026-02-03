namespace Fasade.Subsystems;

public class SoundEngine
{
    public bool PlaySoundEffects(string audioProfile, double volume = 0.8)
    {
        Console.WriteLine($"[SoundEngine] Spouštím zvukový profil '{audioProfile}' s hlasitostí {volume}");
        return true;
    }

    public void LoadAmbientMusic(string trackName)
    {
        Console.WriteLine($"[SoundEngine] Naèítám ambient track '{trackName}'");
    }
}