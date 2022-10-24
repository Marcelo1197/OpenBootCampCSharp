Console.WriteLine("INICIO EJERCICIO 1 \n\n");
decimal precioFijo = 100;
Console.WriteLine("Ingrese nombre:");
String nombre = Console.ReadLine();
Console.WriteLine("Ingrese email:");
String email = Console.ReadLine();
Console.WriteLine("¿Tiene cupón? Ingrese: 01- SI o 02- NO");
Boolean tieneCupon = Int32.TryParse(Console.ReadLine(), out int _resultadoNoUsado);
Console.WriteLine($"Sin descuento: {precioFijo}");
int cupon = 0;
if (tieneCupon)
{
    Console.WriteLine("Ingrese de cuánto % es el descuento del cupón:");
    try
    {
        cupon = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Precio despues del descuento: {precioFijo - (precioFijo * cupon/100)}");
    }
    catch (Exception)
    {
        Console.WriteLine("Ups hubo un error! Volvé a ejecutar la app");
    }
}
Console.WriteLine("FIN EJERCICIO 1 \n\n");
Console.WriteLine("Inicio ejercicio 2\n\n");

Console.WriteLine("Elija un lenguaje:\n1-Python\n2-C#\n3-Java\n4-Javascript");
try
{
    int lenguajeElegido = Int32.Parse(Console.ReadLine());
    switch (lenguajeElegido)
    {
        case 1:
            Console.WriteLine("Elegiste Python");
            break;
        case 2:
            Console.WriteLine("Elegiste C#");
            break;
        case 3:
            Console.WriteLine("Elegiste Java");
            break;
        case 4:
            Console.WriteLine("Elegiste Javascript");
            break;
        default:
            Console.WriteLine("No elegiste ninguno");
            break;
    }

}
catch (Exception)
{
    Console.WriteLine("Ups hubo un error! Volvé a ejecutar la app");
}
finally
{
    Console.WriteLine("Fin ejercicio 2\n\n");
}