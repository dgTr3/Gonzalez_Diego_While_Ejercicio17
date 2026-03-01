Console.WriteLine("contar números positivos");
int numero;
int contador = 0;
Console.WriteLine("Ingrese número (0 es para salir): ");
numero = int.Parse(Console.ReadLine());

while (numero!=0)
{
    if (numero > 0)
    {
        contador++;
    }
    Console.WriteLine("Ingrese número");
    numero = int.Parse(Console.ReadLine());
}
Console.WriteLine("Positovos"+contador);