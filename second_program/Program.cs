Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// число 678
int secondNum = num % 100 / 10;
int thirdNum = num % 10;
int result = 1;

for (int i = 0; i < thirdNum; i++)
{
    result*=secondNum;
}
Console.WriteLine(result);