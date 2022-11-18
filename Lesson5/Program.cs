// УРОК 5. Как не нужно писать код
// Как мы пишем код
// void Method(int maximum)
// {
//       int minimum;
// 	minimum = -maximum;
// 	while (minimum <= maximum)   
// 	{
// 		Console.WriteLine(minimum);
// 		minimum++;
// 	}    
// }
//******************************************************
// Создать массив
// int CreateArray(int N)
// {
// 	int[] arrayA = new int[N * 2 + 1];
// 	for (int i = -N; i < N; i++)
// 	{
// 		arrayA[i + N] = i;
// 	}
// 	return arrayA;
// }	
//***********1 способ как не надо**********************
// bool Metodi(int chislo)
// {
// 	bool resultati - false;
// 	if (chislo % 2 == 0)
// 	{
// 		resultati = true;
// 	}
// 	else 
// 	{
// 		resultati = false;
// 	}
// 	if 	(resultati == false)
// 	{
// 		return false;
// 	}
// 	else
// 	{
// 		return true;
// 	}
// }
//*************************2 способ более читаемый************************
// bool Metodi(int chislo)
// {
// 	bool resultati - false;

// 	if (chislo % 2 == 0) { resultati = true; }
// 	else { resultati = false; }

// 	if (resultati == false) { return false; }
// 	else { return true; }
// }
//***************************3 способ упрощаем************************
// bool Metodi(int chislo)
// {
// 	bool resultati - false;

// 	if (chislo % 2 == 0) { resultati = true; }
// 	else { resultati = false; }

// 	return resultati;
// }
//****************************4 способ - убираем resultati***************
// bool Metodi(int chislo)
// {
// 	if (chislo % 2 == 0) return true; 
// 	else return false;
// }
//*************************5 способ  - вопрос в методе************************
// bool IsEven (int value)
//{
//  	return value % 2 == 0;
//}
//***********************6 способ - используем фишки языка*********************
// * bool IsEven(int value) => value % 2 == 0;
// ** var IsEven = (int v) => v % 2 == 0;

//******************************************************************************
// https://www.npmjs.com/package/is-even -  проверяет число на чётность. 
// var isEven = require('is-even');
 
//isEven(0);
////=> true
//isEven('1');
////=> false
//isEven(2);
////=> true
//isEven('3');
////=> false

