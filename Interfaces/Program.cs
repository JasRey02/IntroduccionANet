using System;


CalculatorService calculator = new CalculatorService();

Console.WriteLine($"Suma: {calculator.Add(5,3)}" );
Console.WriteLine($"Resta: {calculator.Subtract(5,3)}" );
Console.WriteLine($"Multiplicacion: {calculator.Multiply(5,3)}" );
Console.WriteLine($"Division: {calculator.Divide(5,3)}" );