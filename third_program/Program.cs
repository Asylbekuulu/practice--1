// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
Console.WriteLine("Введите числа: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());
int result = 0;

if(firstDigit % secondDigit == 0){
    Console.WriteLine("Числа кратны!");
} else {
    result = firstDigit % secondDigit;
    Console.WriteLine("Остаток от деления равен " + result);
}
