// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int num = new Random ().Next(100,1000);
Console.WriteLine(num);
int result = 0;
while(result==0)
        // for (int i=0; i <lenght; i++);
{
    if (num>99&& num<1000)
{
result = num%10;
}
num/=10; //иначе num = num/10
}
Console.WriteLine(result);