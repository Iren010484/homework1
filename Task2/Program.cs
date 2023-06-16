//  программа принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Clear(); // очистка экрана
Console.Write("Введите первое число =>"); //приглашение ввода для пользователя
string num1 = Console.ReadLine(); //Ввод пользователем строки
int number1 = Convert.ToInt32(num1); //Перевод строки в число
Console.Write("Введите второе число =>"); //приглашение ввода для пользователя
string num2 = Console.ReadLine(); //Ввод пользователем строки
int number2 = Convert.ToInt32(num2); //Перевод строки в число
Console.Write("Введите второе число =>"); //приглашение ввода для пользователя
string num3 = Console.ReadLine(); //Ввод пользователем строки
int number3 = Convert.ToInt32(num3); //Перевод строки в число
Console.WriteLine($"Вы ввели числа {number1}  и {number2} и {number3}"); // Вывод введенных чисел
if (number1 > number2) 
{
    if (number1 > number3)
    {
        Console.WriteLine ($"Число {number1} - максимальное");
    }
    else 
    {
        Console.WriteLine($"число {number3} - максимальное");
    }
}
    else
    {
     if (number2 > number3)
    {Console.WriteLine ($"Число {number2} - максимальное");} 
    else 
    {Console.WriteLine($"число {number3} - максимальное");}
    }
