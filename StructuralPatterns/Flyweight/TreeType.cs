namespace StructuralPatterns.Flyweight
{
    public class TreeType
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Render(double x, double y, double size)
        {
            Console.WriteLine($"Rendering {_color} {_name} tree with {_texture} texture at ({x}, {y}) with size {size}");
        }
    }
}
