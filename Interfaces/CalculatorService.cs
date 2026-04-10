//CalculatorService va implementar la interface
using Operations;

public class CalculatorService : ICalculatorService
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        Console.WriteLine("En una implementacion de metodo resta diferente");
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        int resultado = a * b;
        return resultado;
    }
    public double Divide(int a, int b)
    {
        if(b==0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        return (double)a / b;
    }

}

