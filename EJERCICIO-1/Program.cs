Console.WriteLine("Ingrese el nombre:");
string Nombre = Console.ReadLine();

Console.WriteLine("Ingrese en nivel XP (1 - 100):");
int XP = int.Parse(Console.ReadLine());

Console.WriteLine("Tienes suscripción premium? (si/no):");
string Premium = Console.ReadLine();
Boolean esPremium;

if (Premium == "si")
{
    esPremium = true;
}
else
{
    esPremium = false;
}

if (esPremium == true)
{
    Console.WriteLine("Bienvenido " + Nombre + ", tu nivel de XP es: " + XP + " y tienes acceso a contenido exclusivo.");
}
else
{
    Console.WriteLine("Bienvenido " + Nombre + ", tu nivel de XP es: " + XP + " pero no tienes acceso a contenido exclusivo.");
}