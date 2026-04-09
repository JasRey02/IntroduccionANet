using Operaciones;


Operaciones.Calculadora calculadora = new Operaciones.Calculadora();

int resultadoSuma = calculadora.Suma(5,3);
Console.WriteLine($"La suma de 5 y 3 es: {resultadoSuma}");

int resultadoResta = calculadora.Resta(8,3);
Console.WriteLine($"La resta de 8 y 3 es: {resultadoResta}");

int resultadoMultiplicacion = calculadora.Multiplicacion(4,7);
Console.WriteLine($"La multiplicacion de 4 y 7 es: {resultadoMultiplicacion}");

int resultadoDividir = calculadora.Division(2500,3);
Console.WriteLine($"La division de 10 y 2 es: {resultadoDividir}");

//string resultado = calculadora.ResultadoOperacion(8); //este pedazo de codigo lo hemos dejado de ejemplo para que veamos que no se puedde,
//Console.WriteLine($"{resultado}");                    //acceder a un metodo privado que tiene la clase Calculadora


