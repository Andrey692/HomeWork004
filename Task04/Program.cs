//  Задача 4*(не обязательная): Задайте строку, состоящую из слов,
// разделенных пробелами. Сформировать строку, в которой слова расположены
//  в обратном порядке.В полученной строке слова должны быть также
//  разделены пробелами.


// Mетод для обращения порядка слов в строке
static string ReverseWords(string str)
{
          // Разделение строки на слова
    string[] words = str.Split(' ');
          // Обращение порядка слов
    Array.Reverse(words);
          // Соединение слов обратно в строку с пробелами
    return string.Join(" ", words);
}

string input = "Hello my world";
System.Console.WriteLine(input);

string result = ReverseWords(input);

Console.WriteLine(result);
