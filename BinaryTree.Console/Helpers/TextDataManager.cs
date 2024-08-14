
namespace BinaryTree.Console.Helpers
{
    public class TextDataManager
    {
        const string DIRECTORY = @"C:\BinaryData";
        const string FILE_NAME = @"BINARY_DATAS.txt";

        static public void SaveToTextFile(ICustomBinaryTree binaryTree)
        {
            if (!Directory.Exists(DIRECTORY))
                Directory.CreateDirectory(DIRECTORY);

            var path = Path.Combine(DIRECTORY, FILE_NAME);

            if (!File.Exists(path))
            {
                var stream=File.Create(path);
                stream.Dispose();
            }

            File.WriteAllText(path,GetText(binaryTree.Root));
        }

        static string GetText(Node root,string position="-")
        {
            if (root == null) throw new Exception("Root is null reference");

            List<string> nodes=new List<string>();
            nodes.Add($"Root ID:{root.Id.ToString()},\nRoot Value:{root.Value},\nRoot position: {position}");

            if (root.Right != null)
                nodes.Add(GetText(root.Right, "Right"));

            if (root.Left != null)
                nodes.Add(GetText(root.Left, "Left"));
            
            return nodes.ToString();
        }
        
    }
}
