// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int num = vvod("Введите число: ");
// int size = numsize(num);
// summa(num, size);
// int vvod(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int numsize(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void summa(int num, int size)
// {
//     int sum = 0;
//     for (int i = 1; i <= size; i++)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     Console.WriteLine(sum);
// }
