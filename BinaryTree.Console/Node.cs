public class Node
{
    public Guid Id{ get; set; }
    public int Value { get; set; }
    public Node Right { get; set; }
    public Node Left { get; set; }
    public Node()
    {
        Id = Guid.NewGuid();
    }
    public Node(int value) : this()
    {
        Value = value;
    }
}

