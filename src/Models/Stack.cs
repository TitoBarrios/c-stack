namespace Stack.src.Models;

class Stack<T> {
    private Node<T>? head;

    public void Push(T data) {
        if (head == null)
            head = new Node<T>(data, null);
        else {
            Node<T> node = new(data, head);
            head = node;
        }
    }

    public T? Pop() {
        if(head != null) {
            T data = head.Data;
            head = head.Previous;
            return data;
        }
        return default;
    }

    public T? Peek() {
        return head != null ? head.Data : default;
    }

    public bool IsEmpty() {
        return head == null;
    }
    
}
