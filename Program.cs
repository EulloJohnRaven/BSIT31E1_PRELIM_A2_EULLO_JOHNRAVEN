while (true)
{
    Console.WriteLine("Enter first number (or 'exit' to quit)");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    Console.WriteLine("Enter second number");
    string input2 = Console.ReadLine();
    if (input2.ToLower() == "exit")
    {
        break;
    }
    Console.WriteLine("Enter Operator");
    string selection = Console.ReadLine();
    int n1 = int.Parse(input);
    int n2 = int.Parse(input2);

    if (selection == "+")
    {
        int total = n1 + n2;
        Console.WriteLine(total);
    }
    else if (selection == "-")
    {
        int total = n1 - n2;
        Console.WriteLine(total);
    }
    else if (selection == "*")
    {
        int total = n1 * n2;
        Console.WriteLine(total);
    }
    else if (selection == "/")
    {
        if (n2 == 0)
        {
            Console.WriteLine("Cannot Divide By Zero");
        }
        else
        {
            double d1 = double.Parse(input);
            double d2 = double.Parse(input2);
            double total = d1 / d2;
            Console.WriteLine(total);
        }
    }
}