Console.WriteLine("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
Random rand = new Random();
int SNechet = 0;
for (int i = 0; i < n; i++)
{
    mas[i] = rand.Next(-10, 10);
    Console.Write($"{mas[i]} ");
    if (i % 2 != 0) SNechet += mas[i];
}
Console.WriteLine();
Console.Write("Сумма  элементов массива стоящих на нечетных позициях: ");
Console.WriteLine(SNechet);