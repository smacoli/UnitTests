using Calculator.Services;

CalculatorImpl calc = new CalculatorImpl();

float num1 = 5;
float num2 = 10;

Console.WriteLine($"Soma: {num1} + {num2} = {calc.Sum(num1, num2)}");
Console.WriteLine($"Subtrai: {num1} - {num2} = {calc.Subtract(num1, num2)}");
