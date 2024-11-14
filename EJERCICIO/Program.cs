Console.Write("Ingrese el tamaño del arreglo: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Ingrese los " + n + " valores del arreglo:");
for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + (i + 1) + ": ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ingrese la posición a eliminar (1-" + n + "): ");
int pos = int.Parse(Console.ReadLine());

if (pos < 1 || pos > n)
{
    Console.WriteLine("Posición inválida.");
    return;
}

for (int i = pos - 1; i < n - 1; i++)
{
    arr[i] = arr[i + 1];
}
n--;
Console.WriteLine("El arreglo después de eliminar el valor en la posición " + pos + " es:");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();