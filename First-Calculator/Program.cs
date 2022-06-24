




Console.Write("Enter a number:  ");
double num1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Enter an operator:  ");
string op = Console.ReadLine();


Console.Write("Enter a number:  ");
double num2 = Convert.ToDouble(Console.ReadLine());


if (op == "+")
{
    Console.WriteLine($"The answer is = {num1+num2}");
}
else if (op == "-")
{
    Console.WriteLine($"The answer is = {num1 - num2}");
}
else if (op == "x")
{
    Console.WriteLine($"The answer is = {num1 * num2}");
}
else if (op == "/")
{
    Console.WriteLine($"The answer is = {num1 / num2}");
}
else
{
    Console.WriteLine($"You entered an invalid operator");
}


















