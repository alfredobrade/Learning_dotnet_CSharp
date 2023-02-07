//using Internal;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Ejercicio1");

Console.WriteLine("ingrese cantidad de minutos");
var min = Convert.ToInt32(Console.ReadLine());
var horas = (min/60) - (min % 60);
Console.WriteLine(min/60);
Console.WriteLine(min%60);
Console.WriteLine(horas);
Console.WriteLine("ingrese cantidad de minutos");
var dias = (horas/24) - horas%24;
horas = horas%24 *24;
Console.WriteLine("equivale a "+ dias +"dias y "+horas+"horas");

