Console.WriteLine("ingrese su valor a pagar");
float valor = float.Parse(Console.ReadLine());

float opcion1 = 0.10f;
float opcion2 = 0.15f;
float opcion3 = 0.20f;
float TotalPagar = 0;

Console.WriteLine("ingrese el porcentaje q propina q desea dejar (10,15,20: ");
int porcentaje = int.Parse(Console.ReadLine());

switch (porcentaje)
{
    case 10:
        TotalPagar += (valor + (valor * opcion1));
        break;
    case 15:
        TotalPagar += (valor + (valor * opcion2));
        break;
    case 20:
        TotalPagar += (valor + (valor * opcion3));
        break;
    default:
        Console.WriteLine("ingrese un porcentaje valido");
        break;
}
if (TotalPagar > 100000)
{
    Console.WriteLine($"Su total a pagar con propina es: {TotalPagar} ¡Gracias por esa propina bondadosa!");
}
else
{
    Console.WriteLine("Su total a pagar con propina es: " + TotalPagar);
}