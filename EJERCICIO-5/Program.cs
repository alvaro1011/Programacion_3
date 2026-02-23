Console.WriteLine("Ingrese el color actual del semáforo (Verde, Amarillo, Rojo): ");
string color = Console.ReadLine();

if (color.ToLower() == "verde")
{
    Console.WriteLine("Sigue adelante");
}
else if (color.ToLower() == "amarillo")
{
    Console.WriteLine("Prepárate para frenar");
}
else if (color.ToLower() == "rojo")
{
    Console.WriteLine("¡Detente!");
}
else
{
    Console.WriteLine("Color no reconocido");
}