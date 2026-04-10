using System;
using Newtonsoft.Json;

public class Person
{
    public string Name{get; set;}
    public int Age{get; set;}
    public string Genero{get; set;}
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person
        {
            Name = "Jas Rey",
            Age = 38,
            Genero = "femenino"
        };

        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serialized JSON: " + json);//muestra la informacion en formato json

        var deserializePerson = JsonConvert.DeserializeObject<Person>(json);//convierte la cadena json en un objeto
        Console.WriteLine($"Deserialized Person: Name = {deserializePerson.Name}, Age = {deserializePerson.Age}, Genero = {deserializePerson.Genero}");

    }
}