using System;
//EJERCIO 1 CADENA melvin perez ramirez    
Console.Write("Ingrese una serie de caracteres: ");
string cadena = Console.ReadLine();

if (cadena.Length < 25)
{
    Console.Write("¿Desea rellenar por la izquierda (I) o por la derecha (D)? ");
    char opcion = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (opcion == 'I' || opcion == 'i')
    {
        cadena = new string('$', 25 - cadena.Length) + cadena;
    }
    else if (opcion == 'D' || opcion == 'd')
    {
        cadena = cadena + new string('$', 25 - cadena.Length);
    }
    else
    {
        Console.WriteLine("Opción no válida. No se realizó el relleno.");
    }
}