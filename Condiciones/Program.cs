int edad = 38;

Console.Write("Introduce tu edad:");
edad = Convert.ToInt32(Console.ReadLine());
if(edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
    Console.WriteLine("Ya puedes votar");
}
else
{
    Console.WriteLine("Eres menor de edad");
    Console.WriteLine("Aun no puedes votar");
}