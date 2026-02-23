Console.WriteLine("==== DISCOTECA ====");
int PuestosMaximos = 50;
int PuestosOcupados = 0;

while (true)
{
    int EspaciosDisponibles = PuestosMaximos - PuestosOcupados;

    Console.WriteLine("\n¿Cuántas personas quieren entrar a la discoteca?: ");
    int PersonasEntrando = int.Parse(Console.ReadLine());

    if (PersonasEntrando <= EspaciosDisponibles)
    {
        PuestosOcupados += PersonasEntrando;
        Console.WriteLine("¡Bienvenidos a la discoteca!");
        Console.WriteLine("Espacios ocupados: " + PuestosOcupados + "/50");
    }
    else
    {
        int debenSalir = PersonasEntrando - EspaciosDisponibles;
        Console.WriteLine("Lo siento, no hay suficiente espacio para todos.");
        Console.WriteLine("Para que puedan entrar, deben salir " + debenSalir + " personas.");
    }
}