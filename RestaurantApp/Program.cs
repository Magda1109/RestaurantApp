using RestaurantApp;

var stack = new BasicStack<double>();
stack.Push(4.5);
stack.Push(43);
stack.Push(222.0);

double sum = 0.0;

while(stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Items: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");