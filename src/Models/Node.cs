namespace Stack.src.Models;

public class Node<T>(T data, Node<T>? previous = null)
{
    public T Data { get; set; } = data;
    public Node<T>? Previous { get; set; } = previous;

}
