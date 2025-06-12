namespace StructuralPatterns.Flyweight
{
    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var key = $"{name}-{color}-{texture}";
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
            }
            return _treeTypes[key];
        }

        public static int GetCreatedTreeTypesCount()
        {
            return _treeTypes.Count;
        }
    }
}
