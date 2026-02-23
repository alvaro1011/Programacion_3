Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese su apellido: ");
string apellido = Console.ReadLine();

Console.Write("Ingrese el nombre de la empresa: ");
string empresa = Console.ReadLine();

string correo = (nombre + "." + apellido + "@" + empresa + ".com").ToLower();

Console.WriteLine("Su correo generado es: " + correo);

Console.ReadLine();
Console.Clear();