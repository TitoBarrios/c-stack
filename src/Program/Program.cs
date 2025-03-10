namespace Stack.src.Models.Program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pila en C#\nEscribe el tamaño de la pila: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Stack<int?> stack = new();
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Escribe el valor {i + 1}: ");
            stack.Push(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Elementos de la pila: ");
        while (stack.Peek() != null)
        {
            int? data = stack.Pop();
            Console.Write(stack.Peek() != null ? $" {data} ->" : $" {data}");
        }
    }
}