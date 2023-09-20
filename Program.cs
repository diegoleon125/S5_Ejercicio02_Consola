Console.Write("Ingrese la base: ");
int bas = int.Parse(Console.ReadLine());
Console.Write("Ingrese el exponente: ");
int expo = int.Parse(Console.ReadLine());
int resultado = 1;

for  (int i = 0; i < expo; i++)
{
    resultado *= bas;
}
Console.Write("La potencia es " + resultado);