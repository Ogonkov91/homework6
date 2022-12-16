//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

{
    double enterNumberK1, enterNumberB1;
    double enterNumberK2, enterNumberB2;
    double resultCoordinateX, resultCoordinateY;

    Console.WriteLine("Укажите запрошенные переменные для двух прямыx заданых уравнением:");
    Console.WriteLine("y = k * x + b");

    Console.Write("k1 = ");
    enterNumberK1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    enterNumberB1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    enterNumberK2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    enterNumberB2 = Convert.ToDouble(Console.ReadLine());

if (enterNumberK1 != enterNumberK2)
{
    resultCoordinateX = (enterNumberB2 - enterNumberB1) / (enterNumberK1 - enterNumberK2);
    resultCoordinateY = enterNumberK2 * resultCoordinateX + enterNumberB2;

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine($"X = {resultCoordinateX} ; Y = {resultCoordinateY}");
}
else if (enterNumberB1 == enterNumberB2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");

    // resultCoordinateY = K2 * resultCoordinateX + B2
    // K1 * resultCoordinateX + B1 = K2 * resultCoordinateX + B2
    // K1 * resultCoordinateX - K2 * resultCoordinateX = B2 - B1
    // (K1 - K2) * resultCoordinateX = B2 - B1
    // resultCoordinateX = (B2 - B1) / (K1 - K2)

}