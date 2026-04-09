/*Console.WriteLine("1-Restar");
Console.WriteLine("2-Suma");
Console.Write("Digite el numero para realizar la operacion:");

int operacion = 0;
operacion = Convert.ToInt32(Console.ReadLine());

switch(operacion)
{
    case 1:
        Console.WriteLine($"Haz seleccionado {operacion}");
        break;
    case 2:
        Console.WriteLine($"Haz seleccionado {operacion}");
        break;
    default:
        Console.WriteLine("Operacion no valida");
        break;
}*/
string operacion;
void MenuOpciones()
{    
    Console.WriteLine("Restar");
    Console.WriteLine("Sumar");
    Console.WriteLine("Multiplicar");
    Console.WriteLine("Dividir");
    Console.WriteLine("Salir");
    Console.Write("Digite la operacion que quieras realizar:");
    operacion = Console.ReadLine().ToLower();
}

int resultado;
bool continuar = true;

do{
    MenuOpciones();
    
    switch(operacion)
    {
        case "restar":
            Console.WriteLine($"Haz seleccionado {operacion}");
            resultado = Resta(5,10);
            Console.WriteLine($"El resultado de la resta es: {resultado}");            
            break;
        case "sumar":
            Console.WriteLine($"Haz seleccionado {operacion}");
            resultado = Suma(1,5);
            Console.WriteLine($"El resultado de la suma es: {resultado}");           
            break;
        case "multiplicar":
            Console.WriteLine($"Haz seleccionado {operacion}");
            resultado = Multiplicar(2,5);
            Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
            break;
        case "dividir":
            Console.WriteLine($"Haz seleccionado {operacion}");
            resultado = Dividir(10,2);
            Console.WriteLine($"El resultado es {resultado}");
            break;
        case "salir":
            Console.WriteLine("Nos vemos...regresa pronto...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Operacion no valida");
            break;
    }
}while(continuar);  


int Suma(int numero1, int numero2)
{
    Console.WriteLine($"La suma de {numero1} + {numero2} es: {numero1 + numero2}");
    int resultado = numero1 + numero2;
    return resultado;
}

/*int numeroResultado = Suma(5,10);
Console.WriteLine($"El resultado de la suma es: {numeroResultado}");*/

int Resta(int numero1, int numero2)
{
    //Console.WriteLine($"La resta de {numero1} y {numero2} es: {numero1 - numero2}");
    int result = numero1 - numero2;
    return result;
}

//int ResultadoResta = Resta(5,10);
//Console.WriteLine($"El resultado de la resta es {ResultadoResta}");

int Multiplicar(int numero1, int numero2)
{
    int result = numero1 * numero2;
    return result;
}

int Dividir(int numero1, int numero2)
{
    int result = numero1/numero2;
    return result;
}