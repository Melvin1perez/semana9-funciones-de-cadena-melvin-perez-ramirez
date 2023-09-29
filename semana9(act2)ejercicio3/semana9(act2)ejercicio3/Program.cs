//ejercicio 3 cadena melvin alexander perez ramirez
string frase = "MI MAMA ME MIMA, AMO A MI MAMA";
frase = frase.ToLower();
string[] palabras = frase.Split(' ');

foreach (string palabra in palabras)
{
    if (palabra.Length < 3)
    {
        Console.Write(palabra + "% ");
    }
    else
    {
        Console.Write(palabra + " ");
    }
}