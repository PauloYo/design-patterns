namespace StructuralPatterns.Composite
{

    public class MenuItem : IMenuComponent
    {
        private readonly string _name;
        private readonly decimal _price;

        public MenuItem(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display(int depth = 0)
        {
            var indent = new string(' ', depth * 2);
            Console.WriteLine($"{indent}- {_name}: ${_price:F2}");
        }

        public void Add(IMenuComponent component)
        {
            throw new NotSupportedException("Cannot add to a menu item");
        }

        public void Remove(IMenuComponent component)
        {
            throw new NotSupportedException("Cannot remove from a menu item");
        }
    }
}