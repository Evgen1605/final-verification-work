//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;

PrintArray(elements);

// string[] FormsArrString(string elements)
// {

// }

void PrintArray(string inArray)
{
  Console.Write("[ ");
  for (int i = 0; i < inArray.Length; i++)
  {
    Console.Write($"{inArray[i]} ");
  }
  Console.Write(" ]");
}