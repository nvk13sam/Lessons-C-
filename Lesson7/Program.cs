// УРОК 7. Дополнительная лекция. Рекурсия 
// Основное  - описать условие выхода из рекурсии!!!! иначе она замкнется на себя

//1. Собираем строку с числами от a до b, a≤b (итеративный способ)
// string NumbersFor(int a, int b)
// {
// 	string result = String.Empty;
// 	for (int i = a; i <= b; i++)	
// 	{
// 		result += $"{i} ";	
// 	}
// 	return result;
// }
// string result =  NumbersFor(15, 150); // "\t" - табуляция
// Console.WriteLine(result);
//*************************************************************************************************
// 2. Второй способ - Собираем строку с числами от a до b, a≤b (через методы и через рекурсию)

// string NumbersFor(int a, int b)
// {
// 	string result = String.Empty;
// 	for (int i = a; i <= b; i++)	
// 	{
// 		result += $"{i} ";	
// 	}
// 	return result;
// }

// string NumbersRec(int a, int b)
// {
// 	if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
// 	else return String.Empty;
	
// }	
// Console.WriteLine(NumbersFor(10, 100));
// Console.WriteLine(NumbersRec(1, 10));

//*******************************************************************************************
// 3. Собираем строку с числами от a до b, a>=b (через методы и через рекурсию)
// string NumbersFor(int a, int b)
// {
// 	string result = String.Empty;
// 	for (int i = a; i >= b; i--)	
// 	{
// 		result += $"{i} ";	
// 	}
// 	return result;
// }
// string NumbersRec(int a, int b)
// {
// 	if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
// 	else return String.Empty; // обязательное условие выхода	
// }	
// Console.WriteLine($" Через метод NumbersFor получим = {NumbersFor(100, 0)}");
// System.Console.WriteLine();
// Console.WriteLine($" Через рекурсию NumbersRec получим = {NumbersRec(1, 20)}");

//*****************************************************************************
//4. Ищем сумму чисел от 1 до n
// int SumFor(int n)
// {
// 	int result = 0;
// 	for (int i = 0; i <= n; i++)
// 	{
// 		result += i;
// 	}
// 	return result;
// }
// int SumRec(int n)
// {
// 	if (n == 0) return 0;	// или можно записать if (n == 1) return 1 - это обязательное условие выхода из цикла
// 	else return n + SumRec(n-1);

// }
// Console.WriteLine(SumFor(100));
// System.Console.WriteLine();
// Console.WriteLine(SumRec(10));

// *********************************************************************************************************
// 5. Факториал числа (наглядное сравнение метода и рекурсии)
// int FactorialFor(int n)
// {
// 	int result = 1;
// 	for (int i = 1; i <= n; i++)
// 	{
// 		result *= i;   // result = result * i
// 	}
// 	return result;
// }

// int FactorialRec(int n)
// {
// 	if (n == 0) return 1;
// 	else return n * FactorialRec(n - 1);
// }
// Console.WriteLine($" Через метод FactorialFor получим {FactorialFor(5)}");  // выводит факториал числа 5!
// System.Console.WriteLine();
// Console.WriteLine($" Через рекурсию NumbersRec получим  вывод на консоль  {FactorialRec(10)}");// получаем факториал числа 10

//*************************************************************************************************************************
// 6. Возводим число а в натуральную степень n* (для примера возводим число 2 в степень 4, 6 и 8 разными способами) 
// (PowerFor(2, 4)) (PowerRec(2, 6)) (PowerRecMath(2, 8))

// double PowerFor(double a, double n)
// {
// 	double result = 1;
// 	for (double i = 1; i <= n; i++) 
// 	{
// 		result = result * a;	
// 	}
// 	return result;
// }

// int PowerRec (int a, int n)					//2^3 * 2^5 = 2^8
// {	//return n == 0 ? 1 : PowerRec(a, n - 1) * a;		//a^m * a^n = a^(m+n)
// 	if (n == 0) return 1;
// 	else return PowerRec (a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)					//2^12 = (2^2)^6
// {										//(a^m)^n = a^(m*n)
// 	if (n == 0) return 1;
// 	else if (n %2 == 0) return PowerRecMath(a * a, n / 2);
// 	else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 4));
// System.Console.WriteLine();
// Console.WriteLine(PowerRec(2, 6));
// System.Console.WriteLine();
// Console.WriteLine(PowerRecMath(2, 8));

//******************************************************************************
//7.  Перебор слов (итеративный способ)
// char[] s = { 'а', 'и', 'с', 'т'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
// 	for (int j = 0; j < count; j++)
// 	{
// 		for (int k = 0; k < count; k++)
// 		{
// 			for (int l = 0; l < count; l++)
// 			{
// 				Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}");
// 			}		
// 		}
// 	}
// }

//***********************************************************************************
//8. Перебор слов (рекурсивный метод)
// int n = 1;
// void FindWords (string alphabet, char[] word, int length = 0) // char - массив из букв, которые будут составлять новое слово
// {
// 	if (length == word.Length)
// 	{
// 		Console.WriteLine($"{n++} {new String(word)}"); return;
// 	}
// 	for (int i = 0; i < alphabet.Length; i++)
// 	{
// 		word[length] = alphabet[i];
// 		FindWords(alphabet, word, length + 1);
// 	}
// }
// FindWords("аст", new char[5]);

//******************************************************************************************
// // 9. Поиск папок на компе через цикл
// string path = "C:/Homework/Work001/task2";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// // DirectoryInfo.(+3 overloads)
// for (int i = 0; i < fi.Length; i++)
// {
// 	System.Console.WriteLine(fi[i].Name);
// }
//*************************************************************************
// 9. Поиск папок на компе через рекурсию

// void CatalogInfo(string path, string indent = "")
// {
// 	DirectoryInfo catalog = new DirectoryInfo(path);
// 	DirectoryInfo[] catalogs = catalog.GetDirectories();
// 	for (int i = 0; i < catalogs.Length; i++)
// 	{
// 		Console.WriteLine($"{indent}{catalogs[i].Name}");
// 		CatalogInfo(catalogs[i].FullName, indent + " ");
// 	}
// 	FileInfo[] files = catalog.GetFiles();
// 	for (int i = 0; i < files.Length; i++)
// 	{
// 		Console.WriteLine($"{indent}{files[i].Name}");
// 	}
// }
// string path = @"C:/Homework/Work001/task2";
// CatalogInfo(path);

//*****************************************************************************
// 9. Игра в пирамидки

// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
// 	if (count > 1) Towers(with, some, on, count - 1);
// 	Console.WriteLine($"{with} >> {on}");
// 	if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

//******************************************************************************
//10. Обход разных структур на примере: ((4-2) * (1+3)) / 10
// где разложили по иерархии знаки и цифры: / = 1, * = 2, 10 = 3 и т.д.
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //			 0    1    2     3    4    5    6    7    8    9    10   11 
// void InOrderTraversal(int pos = 1)
// {
// 	if (pos < tree.Length)
// 	{
// 		int left = 2 * pos;
// 		int right = 2 * pos + 1;
// 		// Console.Write(tree[pos] + " ");
// 		if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
// 		Console.Write(tree[pos] + " ");
// 		if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
// 		// if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
// 		// Console.Write(tree[pos] + " ");
// 	}
// }
// InOrderTraversal();

//***********************************************************************************************************************
// 11. Опять Фибоначчи (итерации и рекурсия) с подсчетом времени вычисления
