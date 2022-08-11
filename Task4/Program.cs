Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= value)
{
    Console.WriteLine(count);
    count + 2;
}
