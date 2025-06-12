namespace StructuralPatterns.Facade
{
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound system is on");
        public void SetVolume(int volume) => Console.WriteLine($"Sound volume set to {volume}");
        public void Off() => Console.WriteLine("Sound system is off");
    }
}