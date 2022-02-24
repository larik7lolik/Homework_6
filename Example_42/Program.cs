// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
// Нужно запросить ввод чисел, когда захочет остановить нажать на любую цифру или всё что <= 0.
// Сделать счетчик отдельный в цикле, который будет считать кол-во введенных цифр.

string getNumberStr = String.Empty;
int getNumber = 1;
int i = 0;
Console.WriteLine("Введите число, для выхода нажмите 0 или любую букву:");
while (getNumber != 0  && getNumber > 0)
{
    getNumberStr = Console.ReadLine();
    int.TryParse(getNumberStr, out getNumber);
    i++;
    if(getNumber == 0 || getNumber < 0)
    i--;
}
Console.WriteLine($"Вы ввели {i} чисел");





