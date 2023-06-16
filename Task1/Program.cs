// Программа принимает на вход два числа и определяет, какое из них больше, а какое меньше.
Console.Clear(); // очистка экрана
Console.Write("Введите первое число =>"); //приглашение ввода для пользователя
string num1 = Console.ReadLine(); //Ввод пользователем строки
int number1 = Convert.ToInt32(num1); //Перевод строки в число
Console.Write("Введите второе число =>"); //приглашение ввода для пользователя
string num2 = Console.ReadLine(); //Ввод пользователем строки
int number2 = Convert.ToInt32(num2); //Перевод строки в число
Console.WriteLine($"Вы ввели числа {number1}  и {number2}"); // Вывод введенных чисел
if (number1 > number2) 
{
    Console.WriteLine($"число {number1} больше числа {number2}");
}
    else
    {
       Console.WriteLine($"число {number2} больше числа {number1}"); 
    }