using MotoApp;

var stack = new BasicStack<double>();
var stackString = new BasicStack<string>();
stack.Push(4.5);
stack.Push(43);
stack.Push(333.6);

stackString.Push("Company");
stackString.Push("Company2");
stackString.Push("Company3");


double sum = 0.0;
string sumInt = null;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

while (stackString.Count > 0)
{
    string item2 = stackString.Pop();
    Console.WriteLine($"Item: {item2}");
    sumInt += item2;
}

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Sum: {sumInt}");