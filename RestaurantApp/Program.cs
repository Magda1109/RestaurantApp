using RestaurantApp;

var stack = new Stack<double>();
stack.Push(4.5);
stack.Push(4);
stack.Push(433.5);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");