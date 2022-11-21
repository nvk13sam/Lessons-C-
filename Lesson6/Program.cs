// УРОК 6. Принципы и антипаттерны
//
// Об именовании переменных, классов и других сущностей в языке С# можно почитать в документации:
// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/identifier-names
// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions

//***************************************************************
//1. Антипаттерны - магические числа или константы
// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeight / 2; 

// void DrawText(string caption, int  screenWidthPosition, int  screenHeightPosition);

// DrawText(
//    text: caption,
// 	left: screenWidthPosition,
// 	top: screenHeightPosition   
// 	);
//**************************************************************************************
// Пример 1. Вывод корней квадратного уравнения (округление double до 2-х знаков)
// double a = 4, b = -48, c = 60;
// var d = b * b - 4 * a * c;
// double x1 = (- b + Math.Sqrt(d)) / (2 * a);
// double x2 = (- b - Math.Sqrt(d)) / (2 * a);
// Console.WriteLine($"x1 =" + Math.Round(x1,2));
// Console.WriteLine($"x2 =" + Math.Round(x2,2));
// // *************************************************************************************
// 2. Способ дискреминант через метод

// public Roots Solve(double a, double b, double c)
// {
// 	var d = b * b - 4 * a * c;
// 	double x1 = (- b + Math.Sqrt(d)) / (2 * a);
// 	double x2 = (- b - Math.Sqrt(d)) / (2 * a);
// 	return new Roots {X1 = x1, X2 = x2};
// }
//***********************************************************************************
// Программа рисует случайные символы на консоли

// **********Рисует случайные числа на консоли**************
// Random r = new Random();
// Console.CursorVisible = false;
// while (true)
// {
// 	Console.SetCursorPosition(
// 		left: r.Next(Console.WindowWidth),
// 		top: r.Next(Console.WindowHeight)
// 	);
// 	Console.Write(r.Next(10));
// 	Thread.Sleep(1);
// }
// int t = r.Next(10);
// if (t <= 2)
// 	return (char) ('0' + r.Next(10));
// else 
// 	if (t <= 4)
// 	return (char) ('a' + r.Next(27));
// else 
// 	if (t <= 6)
// 	return (char) ('A' + r.Next(27));
// else 
// 	return (char) (r.Next(32, 255));