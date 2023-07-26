using System;


class Program
{
    static List<string> history = new List<string>(); // List to store the history of operations
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");


        bool continueoperation = true;
        double memoryValue = 0;
        bool isMemorySet = false;

        while (continueoperation)
        {
            Console.Write("Select the operation that you want to perform\n\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Exponent\n" +
                "6. Square root\n" +
                "7. Modulus\n" +
                "8. Store in Memory\n" +
                "9. Recall from Memory\n" +
                "10. Multiple Operand Operations\n" +
                "11. Sine (sin)\n" +
                "12. Cosine (cos)\n" +
                "13. Tangent (tan)\n" +
                "14. Convert Degrees to Radians\n" +
                "15. Convert Radians to Degrees\n" +
                "16.Convert Feet to Meters\n" +
                "17.Convert Meters to Feet\n" +
                "18.Convert Pounds to Kilograms\n" +
                "19.Convert Kilograms to Pounds\n" +
                "20.Convert Celsius to Fahrenheit\n" +
                "21.Convert Fahrenheit to Celsius\n" +
                "------- : ");


            string op = Console.ReadLine().ToLower();

            double num1, num2, result = 0;

            switch (op)
            {
                case "1":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    history.Add($"{num1} + {num2} = {result}"); 
                    break;
                case "2":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    history.Add($"{num1} - {num2} = {num1 - num2}"); 
                    break;
                case "3":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    history.Add($"{num1} * {num2} = {num1 * num2}"); 
                    break;
                case "4":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($" {num1} / {num2} = {result}");
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                case "5":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine($"Result: {num1} ^ {num2} = {result}");
                    history.Add($"{num1} ^ {num2} = {result}"); 
                    break;
                case "6":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Result: √{num1} = {result}");
                    history.Add($"√{num1} = {result}");
                    break;
                case "7":
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 % num2;
                    Console.WriteLine($"Result: {num1} % {num2} = {result}");
                    history.Add($"{num1} % {num2} = {result}");
                    break;
                case "8":
                    Console.Write("Enter the first number: ");
                    memoryValue = Convert.ToDouble(Console.ReadLine());
                    isMemorySet = true;
                    Console.WriteLine($"The value Stored is : = {memoryValue}");
                    history.Add($"{memoryValue}");
                    break;
                case "9":
                    if (isMemorySet)
                    {
                        Console.WriteLine($"The stored value is : = {memoryValue}");
                    }
                    else
                    {
                        Console.WriteLine("There is no value stored. Please store a value first");
                    }
                    break;
                case "10":
                    string expression = GetExpressionInput("Enter the expression (e.g., 2 + 3 * 4): ");
                    result = EvaluateExpression(expression);
                    Console.WriteLine($"Result: {expression} = {result}");
                    history.Add($"{expression} = {result}");
                    break;

                case "11":
                    Console.Write("Enter the angle in degrees: ");
                    double angleDegrees = GetDoubleInput();
                    double angleRadians = DegreesToRadians(angleDegrees);
                    result = Math.Sin(angleRadians);
                    Console.WriteLine($"Result: sin({angleDegrees}°) = {result}");
                    history.Add($"sin({angleDegrees}°) = {result}");
                    break;

                case "12":
                    Console.Write("Enter the angle in degrees: ");
                    angleDegrees = GetDoubleInput();
                    angleRadians = DegreesToRadians(angleDegrees);
                    result = Math.Cos(angleRadians);
                    Console.WriteLine($"Result: cos({angleDegrees}°) = {result}");
                    history.Add($"cos({angleDegrees}°) = {result}");
                    break;

                case "13":
                    Console.Write("Enter the angle in degrees: ");
                    angleDegrees = GetDoubleInput();
                    angleRadians = DegreesToRadians(angleDegrees);
                    result = Math.Tan(angleRadians);
                    Console.WriteLine($"Result: tan({angleDegrees}°) = {result}");
                    history.Add($": tan({angleDegrees}°) = {result}");
                    break;

                case "14":
                    Console.Write("Enter the angle in degrees: ");
                    angleDegrees = GetDoubleInput();
                    angleRadians = DegreesToRadians(angleDegrees);
                    Console.WriteLine($"Result: {angleDegrees}° = {angleRadians} radians");
                    history.Add($": {angleDegrees}° = {angleRadians} radians");
                    break;

                case "15":
                    Console.Write("Enter the angle in radians: ");
                    angleRadians = GetDoubleInput();
                    angleDegrees = RadiansToDegrees(angleRadians);
                    Console.WriteLine($"Result: {angleRadians} radians = {angleDegrees}°");
                    history.Add($": {angleRadians} radians = {angleDegrees}°");
                    break;
                case "16":
                    Console.Write("Enter the length in feet: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = FeetToMeters(num1);
                    Console.WriteLine($"Meters: {result}");
                    history.Add($":Meters: {result}");
                    break;
                case "17":
                    Console.Write("Enter the length in meters: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = MetersToFeet(num1);
                    Console.WriteLine($"Feet: {result}");
                    history.Add($":Feet: {result}");
                    break;
                case "18":
                    Console.Write("Enter the weight in pounds: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = PoundsToKilograms(num1);
                    Console.WriteLine($"Kilograms: {result}");
                    history.Add($":Kilograms: {result}");
                    break;
                case "19":
                    Console.Write("Enter the weight in kilograms: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = KilogramsToPounds(num1);
                    Console.WriteLine($"Pounds: {result}");
                    history.Add($":Pounds: {result}");
                    break;
                case "20":
                    Console.Write("Enter the temperature in Celcius: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = CelsiusToFahrenheit(num1);
                    Console.WriteLine($"Fahrenheit: {result}");
                    history.Add($":Fahrenheit: {result}");
                    break;
                case "21":
                    Console.Write("Enter the temperature in Fahrenheit: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = FahrenheitToCelsius(num1);
                    Console.WriteLine($"Celsius: {result}");
                    history.Add($":Celsius: {result}");
                    break;

                case "clear":
                    ClearHistory(); // Call the ClearHistory function to clear the history
                    break;
                case "history":
                    ShowHistory(); // Call the ShowHistory function to display the history
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            Console.WriteLine("Do you want to continue the operation? y/n");
            string continuechoice = Console.ReadLine().ToLower();

            if (continuechoice == "y")
            {
                continueoperation = true;
            }
            else
            {
                continueoperation = false;
            }

        }

        Console.WriteLine("thank you for using our calculator");


    }

    static double GetDoubleInput()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return value;
    }

    static string GetExpressionInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();
        return input?.ToLower() ?? "";
    }


    // ... Existing methods for GetDoubleInput and GetExpressionInput ...

    static double EvaluateExpression(string expression)
    {
        Queue<string> rpnQueue = ShuntingYard(expression);
        return EvaluateRPN(rpnQueue);
    }

    static Queue<string> ShuntingYard(string expression)
    {
        Queue<string> outputQueue = new Queue<string>();
        Stack<string> operatorStack = new Stack<string>();

        string[] tokens = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            if (IsNumeric(token))
            {
                outputQueue.Enqueue(token);
            }
            else if (IsOperator(token))
            {
                while (operatorStack.Count > 0 && IsOperator(operatorStack.Peek()) &&
                       GetPrecedence(token) <= GetPrecedence(operatorStack.Peek()))
                {
                    outputQueue.Enqueue(operatorStack.Pop());
                }
                operatorStack.Push(token);
            }
        }

        while (operatorStack.Count > 0)
        {
            outputQueue.Enqueue(operatorStack.Pop());
        }

        return outputQueue;
    }

    static double EvaluateRPN(Queue<string> rpnQueue)
    {
        Stack<double> operandStack = new Stack<double>();

        while (rpnQueue.Count > 0)
        {
            string token = rpnQueue.Dequeue();

            if (IsNumeric(token))
            {
                operandStack.Push(double.Parse(token));
            }
            else if (IsOperator(token))
            {
                if (operandStack.Count < 2)
                {
                    throw new InvalidOperationException("Invalid expression: Not enough operands for operator.");
                }

                double operand2 = operandStack.Pop();
                double operand1 = operandStack.Pop();

                double result = PerformOperation(operand1, operand2, token);
                operandStack.Push(result);
            }
        }

        if (operandStack.Count != 1)
        {
            throw new InvalidOperationException("Invalid expression: Too many operands.");
        }

        return operandStack.Pop();
    }

    static bool IsNumeric(string token)
    {
        return double.TryParse(token, out _);
    }

    static bool IsOperator(string token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/" || token == "^" || token == "sqrt" || token == "%";
    }

    static int GetPrecedence(string op)
    {
        switch (op)
        {
            case "+":
            case "-":
                return 1;
            case "*":
            case "/":
            case "%":
                return 2;
            case "^":
            case "sqrt":
                return 3;
            default:
                return 0;
        }
    }

    static double PerformOperation(double operand1, double operand2, string op)
    {
        switch (op)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                return operand1 / operand2;
            case "^":
                return Math.Pow(operand1, operand2);
            case "sqrt":
                return Math.Sqrt(operand1);
            case "%":
                return operand1 % operand2;
            default:
                throw new InvalidOperationException("Invalid operator.");
        }
    }

    static double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }

    static double RadiansToDegrees(double radians)
    {
        return radians * (180 / Math.PI);
    }

    static double FeetToMeters(double feet)
    {
        return feet * 0.3048;
    }

    static double MetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    static double PoundsToKilograms(double pounds)
    {
        return pounds * 0.453592;
    }

    static double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9.0 / 5.0 + 32.0;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32.0) * 5.0 / 9.0;
    }

     static void ShowHistory()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("History is empty.");
        }
        else
        {
            Console.WriteLine("History:");
            foreach (string entry in history)
            {
                Console.WriteLine(entry);
            }
        }
    }

    static void ClearHistory()
    {
        history.Clear();
        Console.WriteLine("History cleared.");
    }
}
