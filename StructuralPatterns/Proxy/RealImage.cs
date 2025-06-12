namespace StructuralPatterns.Proxy
{
    public class RealImage : IImage
    {
        private readonly string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_filename} from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }
}