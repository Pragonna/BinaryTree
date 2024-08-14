
public interface ICustomBinaryTree
{
    Node Root { get; set; }

    Node Add(int value);
    Node FindOrDefault(Guid id);
    void Remove(Guid id);
}