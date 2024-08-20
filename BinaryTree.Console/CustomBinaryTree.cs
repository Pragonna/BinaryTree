
public class CustomBinaryTree : ICustomBinaryTree
{
    public Node Root { get; set; }
    public CustomBinaryTree(int value)
    {
        Root = new Node(value);
    }

    public Node Add(int value) => CheckUntilBeNullWhenAdd(Root, value);
    public void Remove(Guid id) => RemoveNode(Root, id);
    public Node FindOrDefault(Guid id) => FindNode(Root, id);

    /// <summary>
    /// This method is finding alternative position for assign value by create new Node.
    /// It is working recursive - high resource required
    /// </summary>
    /// <param name="root"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    private Node CheckUntilBeNullWhenAdd(Node root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }
        var compare = root.Value.CompareTo(value);
        if (compare < 1)
        {
            root.Right = CheckUntilBeNullWhenAdd(root.Right, value);
            return root;
        }
        root.Left = CheckUntilBeNullWhenAdd(root.Left, value);
        return root;
    }

    /// <summary>
    /// Find Node
    /// </summary>
    /// <param name="root"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    private Node FindNode(Node root, Guid id)
    {
        Node _root;

        if (root.Id.Equals(id))
            return new Node
            {
                Id = root.Id,
                Left = root.Left,
                Right = root.Right,
                Value = root.Value
            };

        if (root.Right != null)
        {
            _root = FindNode(root.Right, id);
            if (_root != null)
                return new Node
                {
                    Id = _root.Id,
                    Left = _root.Left,
                    Right = _root.Right,
                    Value = _root.Value
                };
        }

        if (root.Left != null)
        {
            _root = FindNode(root.Left, id);
            if (_root != null)
                return new Node
                {
                    Id = _root.Id,
                    Left = _root.Left,
                    Right = _root.Right,
                    Value = _root.Value
                };
        }

        return default;
    }

    /// <summary>
    /// Remove Node
    /// </summary>
    /// <param name="root"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    private Node RemoveNode(Node root, Guid id)
    {
        if (root.Id.Equals(id))
        {
            root = null;
            return root;
        }

        if (root.Right != null)
        {
            root.Right = RemoveNode(root.Right, id);
            return root.Right;
        }


        if (root.Left != null)
        {
            root.Left = RemoveNode(root.Left, id);
            return root.Left;
        }

        return default;
    }


}

