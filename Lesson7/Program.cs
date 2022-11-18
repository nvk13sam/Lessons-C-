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

// int PowerRec (int a, int n)
// {	//return n == 0 ? 1 : PowerRec(a, n - 1) * a;
// 	if (n == 0) return 1;
// 	else return PowerRec (a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
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
//7.  Перебор слов
char[] s = { 'а', 'и', 'с', 'т'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
	for (int j = 0; j < count; j++)
	{
		for (int k = 0; k < count; k++)
		{
			for (int l = 0; l < count; l++)
			{
				Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}");
			}		
		}
	}
}
//int n = 1;
void FindWords (string alphabet, char[] word, int length = 0) // char - массив из букв, которые будут составлять новое слово
{
	if (length == word.Length)
	{
		Console.WriteLine($"{n++} {new String(word)}"); return;
	}
	for (int i = 0; i < alphabet.Length; i++)
	{
		word[length] = alphabet[i];
		FindWords(alphabet, word, length + 1);
	}
}
FindWords("аист", new char[2]);

string path = "Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
	System.Console.WriteLine(fi[i].Name);
}
