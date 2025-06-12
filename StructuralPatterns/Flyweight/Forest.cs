namespace StructuralPatterns.Flyweight
{
    public class Forest
    {
        private readonly List<Tree> _trees = new List<Tree>();

        public void PlantTree(double x, double y, double size, string name, string color, string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, size, treeType);
            _trees.Add(tree);
        }

        public void Render()
        {
            foreach (var tree in _trees)
            {
                tree.Render();
            }
        }

        public int GetTreeCount()
        {
            return _trees.Count;
        }
    }
}
