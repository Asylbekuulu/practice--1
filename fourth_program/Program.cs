// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 213455
Console.WriteLine("Введите число: ");
int integer = Convert.ToInt32(Console.ReadLine());
if(integer/100>0){
    Console.WriteLine((integer/100)%10);
} else {
    Console.WriteLine("цифры нет!");
}

