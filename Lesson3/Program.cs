﻿ // УРОК 3. ВИДЫ МЕТОДОВ
//  //Вид 1 - Ничего не принимают, ничего не возвращают. 
//  // в скобках нет аргументов, есть тело, которое может что-то показывать на экран.
//  void Method1()
//  {
//        Console.WriteLine("Автор ....");
//  }
//  //Как вызываются такие методы: скобки обязательно
//  Method1(); 

 //********************************************************************************
 //Вид 2 - Что-то принимают, ничего не возвращают. 
//  // void - ключевое слово, Method2 - идентификатор, 
//  // в скобках есть аргументы (string msg), есть тело
//  void Method2(string msg)
//  {
//  	Console.WriteLine(msg);
//  }
//  //Как вызываются такие методы: скобки обязательно
//  Method2(msg); - Method2("Текст сообщения");
//  //Второй вариант
//  void Method21(string msg, int count)
//  {
//  	int i = 0;
//  	while (i < count)
//  	{
//  		Console.WriteLine(msg);
//  		i++;
//  	}
//  }
//  //Как вызываются такие методы: скобки обязательно
//  Method21(msg: "Текст", count: 4); // или можно наоборот
//  Method21(count: 4, msg: "Новый текст"); 


 //********************************************************************************
 //Вид 3 - Ничего не принимают, что-то возвращают, 
 //например генератор случайных чисел. в скобках нет аргументов

//  int Method3()
//  {
//  	return DataTime.Now.Year;
//  }
//  //Как вызываются такие методы: скобки обязательно
//  int year = Method3();
//  Console.WriteLine(year);

 //*********************************************************************************
 //Вид 4 - Что-то принимают, что-то возвращают. 
 // в скобках есть аргументы, есть тело

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
//Как вызываются такие методы: скобки обязательно
string result = Method4(10, "xvnmz" + "\t"); // "\t" - табуляция
Console.WriteLine(result);

//Второй способ, цикл for
string Method41(int count, string text)
{

	string result = String.Empty;
	for (int i = 0; i < count; i++) //Инициализация счетчика, i < count, i < length
	{
		result = result + text;
	}
	return result;
}	
//Как вызываются такие методы: скобки обязательно
string res = Method41(10, "Пусть будет мир! " + "\n"); // "\n" - перенос на новую строку
Console.WriteLine(res);
