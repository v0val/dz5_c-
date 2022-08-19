Console.WriteLine("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
Random rand = new Random();
int kChet = 0;
for (int i = 0; i < n; i++)
{
    mas[i] = rand.Next(100, 1000);
    Console.Write($"{mas[i]} ");
    if (mas[i] % 2 == 0) kChet += 1;
}
Console.WriteLine();
Console.Write("Количество четных элементов массива: ");
Console.WriteLine(kChet);