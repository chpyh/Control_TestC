/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/
// Далее универсальное решение для любого текста, введенного с консоли.
void FillStrArray(string text, string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        str[i] = string.Empty;
        str[i] = str[i] + text[i];
    }
}
int CountOFWords(string[] str, string text)
{
    int count = 0;
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] != " " && str[i + 1] == " ")
            count++;
    }
    return count;
}

void ArrNoExtraSpaces(string[] words, string[] str)
{
    string result = string.Empty;
    int index = 0;
    for (int i = 0; i < str.Length; i++)
        if (index < words.Length)
        {
            if(str[i] != " ") result = result + str[i];
        
            else if(i != 0 && str[i -1] != " ")
        {
            words[index] = result;
            result = string.Empty;
            index++;
        }
    }
}
int CountOfShortStrings(string[] words)
{
    int count = 0;
    foreach (string s in words)
    {
        if (s.Length < 4)
        {
            count++;
        }
    }
    return count;
}

void LessThanFourChars (string[] words, string[] shortStrings)
{
    int i = 0;
    foreach (string s in words)
    {
        if (s.Length < 4 && i < shortStrings.Length)
        {
            shortStrings[i] = s;
            i++;
        }
    }

Console.WriteLine($"Массив из строк длинной не больше трех символов: \n[{string.Join(" ", shortStrings)}]");
}

Console.Clear();
Console.WriteLine("Введите строку: ");
string text = Console.ReadLine()! + " ";
//Вариант создания массива из слов 1. 
//string[] words = Console.ReadLine()!.Split(new char[] { ' ' }); //это готовая функция. 
//Вариант создания массива из слов 2 - без использования коллекций:
string[] str = new string[text.Length]; // Сначала преобразуем строку в массив срок, чтобы можно было сравнивать значения. 
FillStrArray(text, str); // заполняем массив строк
string[] words = new string[CountOFWords(str, text)];   // Затем создаем массив без лишних пробелов.
ArrNoExtraSpaces(words, str);   // Заполняем массив, очищенный от пробелов.
//Далее общая часть для Варианта 1 и Варианта 2.
string[] shortStrings = new string[CountOfShortStrings(words)];//Рассчитываем размер массива из строк длинной не более трех символов 
LessThanFourChars(words, shortStrings);//Заполянем массив из строк длинной не более трех символов.
