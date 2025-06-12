namespace StructuralPatterns.Facade
{
    public class Lights
    {
        public void Dim(int level) => Console.WriteLine($"Lights dimmed to {level}%");
        public void On() => Console.WriteLine("Lights are on");
    }
}