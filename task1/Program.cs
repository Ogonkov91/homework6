//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

{
    Console.WriteLine("ВВедите любые числа разделённые любым знаком");
    int[] array = Array.ConvertAll(
        FilterStringOutDigitals(Console.ReadLine()).Split(" "),
        int.Parse);

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Введено положительных чисел: " + count);
}

// Убирает из строки все символы кроме чисел и заменяет их пробелом.
string FilterStringOutDigitals(string inputString)
{
    int tempParseNum;
    bool checkDounleChar = true;

    for (int i = 0; i < inputString.Length; i++) // На выходе должны получить строку где все НЕ цифры заменены пробелами
    {
        if (int.TryParse(Convert.ToString(inputString[i]), out tempParseNum)
        || inputString[i] == '-' && int.TryParse(Convert.ToString(inputString[i + 1]), out tempParseNum))
        //первым условием проверяем временную строку на числа 
        //вторым через || считаем числом '-' и оставляем в строке
        //третьим через && фильтруем ошибки ввода знака '-' не перед числом
        //осталась ошибка OutOfRange от inputString[i+1] в случае если знак '-' идёт последним
        {
            checkDounleChar = false;
        }
        else //Заменяем символы пробелом. 
             //Можно попробовать Replace, но я побоялся что она будет сканировать всю строку для каждого уникального символа
        {
            if (checkDounleChar) // удаляем двойные символы
            {
                inputString = inputString.Remove(i, 1);
                checkDounleChar = true;
                i--;
            }
            else
            {
                inputString = inputString.Remove(i, 1);
                inputString = inputString.Insert(i, " ");
                checkDounleChar = true;
            }
        }
    }

    if (checkDounleChar) inputString = inputString.Remove(inputString.Length - 1, 1); // удаляем последний символ если не цифра
    return inputString;
}