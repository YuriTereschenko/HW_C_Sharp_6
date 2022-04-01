/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int count = 0;
int inputNumber;
System.Console.WriteLine("Сколько чисел хотите проверить?");
int countOfNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Вводите числа, после каждого введеного числа нажимайте на Enter");
for (int i = 0; i < countOfNumber; i++)
{
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Из введенных чисел  {count} шт. больше 0.");