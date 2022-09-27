Console.WriteLine("Задайте длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
PrintArray(array);
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}