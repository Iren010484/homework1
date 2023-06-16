//Программа на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Clear(); // очистка экрана
Console.Write("Введите первое число => "); //приглашение ввода для пользователя
string num = Console.ReadLine(); //Ввод пользователем строки
int number = Convert.ToInt32(num); //Перевод строки в число
int remains = number % 2; //Находим остаток от деления
if (remains == 0)
{Console.WriteLine ($"Число {number} - четное");}
else
{{Console.WriteLine ($"Число {number} - нечетное");}}