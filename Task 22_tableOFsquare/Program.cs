// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите N");
int num = Convert.ToInt32(Console.ReadLine());
int c = 1;

while (c<=num)
{
   Console.Write(c*c); // or Console.WriteLine(c*c);
   c++; 
}
