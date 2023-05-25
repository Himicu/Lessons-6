// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 

int InputNumber()
{
    Console.Write("Введите сторону треугольника: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool DoesItExist(int a, int b, int c)
{
    bool result = false;
    if (a + b > c && a + c > b && b + c > a)
    {
        result = true;
    }
    return result;
}
int a = InputNumber();
int b = InputNumber();
int c = InputNumber();
if (DoesItExist(a, b, c))
{
    Console.WriteLine("da");
}
else Console.WriteLine("net");
