//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
//45 -> 101101
//3  -> 11
//2  -> 10

int num;
Console.Write("Введите номер: ");
num = int.Parse(Console.ReadLine());
string rem = "";
while (num > 0)
{
    rem = (num % 2).ToString() + rem;
    num /= 2;
}
Console.WriteLine($"Бинарный формат для заданного номера {rem}");

