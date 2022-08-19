Console.WriteLine("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] mas = new double[n];
mas[0] = Convert.ToDouble(Console.ReadLine());
double max = mas[0];
double min = mas[0];
for (int i = 1; i < n; i++)
{
    mas[i] = Convert.ToDouble(Console.ReadLine());    
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}
Console.WriteLine();
Console.Write("разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(max - min);