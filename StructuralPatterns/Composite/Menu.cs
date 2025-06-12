namespace StructuralPatterns.Composite
{
    public class Menu : IMenuComponent
    {
        private readonly string _name;
        private readonly List<IMenuComponent> _components = new List<IMenuComponent>();

        public Menu(string name)
        {
            _name = name;
        }

        public void Display(int depth = 0)
        {
            var indent = new string(' ', depth * 2);
            Console.WriteLine($"{indent}{_name}:");
            
            foreach (var component in _components)
            {
                component.Display(depth + 1);
            }
        }

        public void Add(IMenuComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IMenuComponent component)
        {
            _components.Remove(component);
        }
    }
}