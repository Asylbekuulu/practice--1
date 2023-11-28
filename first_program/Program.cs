Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = 0;
int secondNumber = 0;
int result = 0;

if(number >= 100 && number <= 999){
    firstNumber = number / 100;
    secondNumber = number % 10;
    result = firstNumber * 10 + secondNumber;

    Console.WriteLine(result);

} else {
    Console.WriteLine("Введенное число не трехзначное!");
}