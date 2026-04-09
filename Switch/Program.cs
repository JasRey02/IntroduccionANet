List<string> nombres2 = new List<string>();
nombres2.Add("Mami");
nombres2.Add("Hermana mayor");
nombres2.Add("Hermana de enmedio");
nombres2.Add("Esposo");

switch(nombres2[0])
{
    case "Mami":
        Console.WriteLine($"Mi {nombres2[0]}, se llama Elia");
        break;
    case "Hermana mayor":
        Console.WriteLine($"Mi {nombres2[1]}, se llama Marcia");
        break;
    case "Hermana de enmedio":
        Console.WriteLine($"Mi {nombres2[2]}, se llama Wendy");
        break;
    case "Esposo":
        Console.WriteLine($"Mi {nombres2[3]}, se llama Alexis");
        break;
    default:
        Console.WriteLine("No se encontro el nombre");
        break;
}