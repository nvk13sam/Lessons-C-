﻿ // УРОК 3. ВИДЫ МЕТОДОВ
 //Вид 1 - Ничего не принимают, ничего не возвращают. 
 // в скобках нет аргументов, есть тело, которое может что-то показывать на экран.
 void Method1()
 {
       Console.WriteLine("Автор ....");
 }
 //Как вызываются такие методы: скобки обязательно
 Method1(); 

 ********************************************************************************
 Вид 2 - Что-то принимают, ничего не возвращают. 
 // void - ключевое слово, Method2 - идентификатор, 
 // в скобках есть аргументы (string msg), есть тело
 void Method2(string msg)
 {
 	Console.WriteLine(msg);
 }
 //Как вызываются такие методы: скобки обязательно
 Method2(msg: "Текст сообщения");

 //Второй вариант
 void Method21(string msg, int count)
 {
 	int i = 0;
 	while (i < count)
 	{
 		Console.WriteLine(msg);
 		i++;
 	}
 }
 //Как вызываются такие методы: скобки обязательно
 Method21(msg: "Текст", count: 4); // или можно наоборот
 Method21(count: 4, msg: "Новый текст"); 


 ********************************************************************************
 Вид 3 - Ничего не принимают, что-то возвращают, 
 например генератор случайных чисел. в скобках нет аргументов

 int Method3()
 {
 	return DataTime.Now.Year;
 }
 //Как вызываются такие методы: скобки обязательно
 int year = Method3();
 Console.WriteLine(year);

 *********************************************************************************
 Вид 4 - Что-то принимают, что-то возвращают. 
 в скобках есть аргументы, есть тело

 string Method4(int count, string text)
 {
 	int i = 0;
 	string result = String.Empty;
 		while (i < count)
 		{
 			result = result + text;
 			i++;

		}
 		return result;

  }
// //Как вызываются такие методы: скобки обязательно
// string result = Method4(10, "xvnmz" + "\t"); // "\t" - табуляция
// Console.WriteLine(result);

// //Второй способ, цикл for
// string Method41(int count, string text)
// {

// 	string result = String.Empty;
// 	for (int i = 0; i < count; i++) //Инициализация счетчика, i < count, i < length
// 	{
// 		result = result + text;
// 	}
// 	return result;
// }	
// //Как вызываются такие методы: скобки обязательно
// string res = Method41(10, "Пусть будет мир! " + "\n"); // "\n" - перенос на новую строку
// Console.WriteLine(res);

//*****************************************************************************************
// 1. Выводим на экран таблицу умножения (интерполяция строк), табуляция и перенос строк

// for (int i = 2; i <= 10; i++)
// {
// 	for (int j = 2; j <= 10; j++)
// 	{
// 		Console.Write($"{i} x {j} = {i * j}" + "\t", "  ");
// 	}
// 	Console.WriteLine();
// }

//****************************************************************************************
// 2. Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача? аргументы - это старые символы, которые надо заменить, используя метод
// string text = "– Я думаю, – сказал князь улыбаясь, – что "
//                + "ежели бы вас послали вместо нашего милого Винценгероде," 
//                + " Вы бы взяли приступом согласие прусского короля. "
//                + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            012345
// // s[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//                string result = String.Empty;
//                int length = text.Length; //Запомнить длину строки, qwerty=6
//                for (int i = 0; i < length; i++)
//                {
//                              if(text[i] == oldValue) result = result + $"{newValue}";
//                              else result = result + $"{text[i]}";// имя аргумента - text 
                             
//                }
//                return result;

// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'е', 'Е');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'В', 'в');
// Console.WriteLine(newText);

//********************************************************************************
//3. Сортируем массив от min до max (методом выбора)

int[] array = { 1, 2, 9, 8, 6, 7, 3, 5, 1, 48, 0, 32, 81, 15, 94, 193, 12, 12, 12, 58, 75 };

void PrintArray(int[] array)
{
              
      int count = array.Length;

    	for (int i = 0; i < count; i++)
      {
            Console.Write($"{array[i]} ");
      }
      Console.WriteLine();               
}
void SelectionSort(int[] array)
{
      for (int i = 0; i < array.Length - 1; i++)
      {
            int minPosition = i;

            for (int j = i +1; j < array.Length; j++)
            {
                  if(array[j] < array[minPosition]) minPosition = j;   
            }               

            int temporary = array[i];// обмен местами, переливаем стаканы
            array[i] = array[minPosition];
            array[minPosition] = temporary;
      }

}

PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);


