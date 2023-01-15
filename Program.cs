//Вариант №1   
Console.WriteLine("Какой длинны массив вам потребуется? ");
int size  = int.Parse(Console.ReadLine()!);

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(", ", arr1));
Console.Write("]");

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= maxSymbols){
		count++;
	}   
}
Console.WriteLine();
Console.Write("Полученный массив из строк, длина которых меньше либо равна трём символам: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxSymbols){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + " ");
        j++;
    }
}
Console.Write("]");



// //Вариант №2

// using System;
// using System.Collections.Generic;

// class Program {
//          static void Main(string[] args) {
//             Console.WriteLine("Введите строки:");

//             var input = new List<string>(); // Создаем список (такой длинный бесконечный массив)
//             string s; // Читаем строки, пока пользователь не введет пустую строку. Строка из пробелов - не пустая

//             while ((s = Console.ReadLine()).Length != 0) {
//                 // Добавляем строку от пользователя в список строк для обработки
//                 input.Add(s);
//             }

//             string[] userInputAsArray = input.ToArray();
//             string[] filteredStrings = Filter(userInputAsArray);
//             // string.Join - объединяет строки в массиве с помощью разделителя ", "
//             string finalString = string.Join(", ", filteredStrings);

//             Console.Out.WriteLine(finalString);
//         }

//         public static string[] Filter(string[] stringsToFilter) {
//             // Определяем сколько значений будет в результирующем массиве
//             int filteredCount = 0; // Размер результирующего массива
//             for (int i = 0; i < stringsToFilter.Length; i++) {
//                 if (stringsToFilter[i].Length <= 3) {
//                     filteredCount += 1;
//                 }
//             }

//             // Если ничего не подходит, то мы сразу возвращаем пустой массив
//             if (filteredCount == 0) {
//                 return new string[] { };
//             }

//             // Создаем массив для результата
//             string[] result = new string[filteredCount];
//             // Номер совпадения
//             int c = 0;

//             for (int i = 0; i < stringsToFilter.Length; i++) {
//                 if (stringsToFilter[i].Length <= 3) {
//                     result[c] = stringsToFilter[i];
//                     c += 1;
//                 }
//             }

//             return result;
//         }
//     }




// //Вариант №3 
// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace ConsoleApp2 {
//     class Program {
//         static void Main(string[] args) {
//             Console.WriteLine("Введите строки:");

//             var filteredStrings = ReadInput().Where(s => s.Length <= 3);

//             string finalString = string.Join(", ", filteredStrings);

//             Console.Out.WriteLine(finalString);
//         }

//         static IEnumerable<string> ReadInput() {
//             string s;
//             // Читаем строки, пока пользователь не введет пустую строку
//             // строка из пробелов - не пустая
//             while ((s = Console.ReadLine()).Length != 0) {
//                 // Добавляем строку от пользователя в список строк для обработки
//                 yield return s;
//             }
//         }
//     }
// }
