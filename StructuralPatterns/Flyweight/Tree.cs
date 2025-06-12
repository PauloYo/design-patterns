namespace StructuralPatterns.Flyweight
{
    public class Tree
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _size;
        private readonly TreeType _treeType;

        public Tree(double x, double y, double size, TreeType treeType)
        {
            _x = x;
            _y = y;
            _size = size;
            _treeType = treeType;
        }

        public void Render()
        {
            _treeType.Render(_x, _y, _size);
        }
    }
}
