List<string> listaNombres = new List<string>();
List<string> listaApellidos = new List<string>();

listaNombres.Add("Janis");
listaNombres.Add("Alexis");
listaNombres.Add("Elia");
listaNombres.Add("Marcia");
listaNombres.Add("Wendy");

listaApellidos.Add("Reyes");
listaApellidos.Add("Lopez");
listaApellidos.Add("Rivera");
listaApellidos.Add("Manzano");
listaApellidos.Add("Interiano");

foreach(string nombre in listaNombres)
{
    foreach(string apellido in listaApellidos)
    {
        Console.WriteLine($"{nombre} {apellido}");
    }
}
