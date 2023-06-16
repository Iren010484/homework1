//программа на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear(); // очистка экрана
Console.Write("Введите число N =>   "); //приглашение ввода для пользователя
string num = Console.ReadLine(); //Ввод пользователем строки
int N = Convert.ToInt32(num); //Перевод строки в число
int current = 0;
while (current < N-1)
{
 Console.WriteLine(current + 2);
 current = current + 2; 
} 
Console.WriteLine ($"Вывели все четные числа от 0 до {N}");
