int[] mas = new int[123];
Random rand = new Random();
int countPosition = 0;
for (int i = 0; i < 123; i++)
{
    mas[i] = rand.Next(-100, 100);
    Console.Write($"{mas[i]} ");
    if (mas[i] < 99 && mas[i] > 10) countPosition += 1;
}
Console.WriteLine();
Console.Write("количество элементов массива, значения которых лежат в отрезке [10,99]: ");
Console.WriteLine(countPosition);