namespace StructuralPatterns.Bridge
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {_color.ApplyColor()} square");
        }
    }
}