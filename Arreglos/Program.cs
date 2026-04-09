string nombre1 = "Oscar";
string nombre2 = "Felipe";

string[] nombres = new string[4]; //objeto de tipo nombre, he inicializacion
nombres[0] = "Alexis";
nombres[1] = "Lombardo";
nombres[2] = "Jas";
nombres[3] = "Stefani";

Console.WriteLine("Los nombres de mi arreglo son:");
foreach(string nombre in nombres)
{
    Console.WriteLine(nombre);
}


List<string> nombres2 = new List<string>();
nombres2.Add("Mami");
nombres2.Add("Hermana mayor");
nombres2.Add("Hermana media");
nombres2.Add("Esposo");
Console.WriteLine("Los nombres de mi lista son:");
foreach(string nombre in nombres2)
{
    Console.WriteLine(nombre);
}