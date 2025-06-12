namespace StructuralPatterns.Facade
{

    public class Projector
    {
        public void On() => Console.WriteLine("Projector is on");
        public void SetInput(string input) => Console.WriteLine($"Projector input set to {input}");
        public void Off() => Console.WriteLine("Projector is off");
    }
}