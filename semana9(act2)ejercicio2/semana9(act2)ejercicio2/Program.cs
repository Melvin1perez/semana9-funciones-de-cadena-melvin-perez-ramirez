//EJERCICIO 2 CADENA MELVIN PEREZ
Console.Write("Ingrese la primera cadena: ");
string cadena1 = Console.ReadLine();
Console.Write("Ingrese la segunda cadena: ");
string cadena2 = Console.ReadLine();

if (string.Compare(cadena1, cadena2) == 0)
{
    Console.WriteLine("Las cadenas son iguales según CompareTo.");
}
else
{
    Console.WriteLine("Las cadenas no son iguales según CompareTo.");
}

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("Las cadenas son iguales según Equals.");
}
else
{
    Console.WriteLine("Las cadenas no son iguales según Equals.");
}
