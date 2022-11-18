// УРОК 1. Знакомство с языком программирования С#
// //Выводит на экран Хэлло, Ворлд!

// Console.WriteLine("2 Hello, World!");

//**2************************2**********************2**************
// //Выводит на экран приветствие по имени

// Console.Write("Ведите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

//**3*************************3**********************3*************
// //Выводит на экран сумму 2-х случайных чисел

// int numberA = new Random().Next(1, 100); // 1 2 3 4 ... 9
// Console.WriteLine(numberA);
// int numberB = new Random().Next(100, 2000);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine($"Сумма 2-х случайных чисел равна {result}");
// Console.WriteLine(result);

//**4**************************4**********************4**************
// // Выдит на экран результат деления 2-х чисел, которые определены заранее 
// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

//**5**************************5**********************5***************
// // if else Приветствовать Машу особенно)  

// Console.WriteLine("Введите имя пользователя");
// string username = Console.ReadLine();

// if (username.ToLower() == "маша") // (username.ToLower() - распознает любое написание МаШа
// {
//                Console.WriteLine ("Ура, это же МАША!");
// }
// else
// {
//                Console.WriteLine ("Привет, ");
//                Console.WriteLine(username);
// }

//**6***********************6********************6*************************
// Задача про гири, ищем максимальное, теперь на С#

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 489;

// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;

// Console.Write ("max = ");
// Console.WriteLine (max);

//**7***************************7********************7************************
// Рисуем фрактал, отмечаем точки, делим отрезки пополам
Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while(count < 5000)
{
               int what = new Random().Next(0, 3); // [0;3] -> 0 1 2
               if (what == 0)
               {
                              x =(x+xa)/2;
                              y =(y+ya)/2;

               }      
               if (what == 1)
               {
                              x =(x+xb)/2;
                              y =(y+yb)/2;    
               }

               if (what == 2)
               {
                              x =(x+xc)/2;
                              y =(y+yc)/2;     
               }
               Console.SetCursorPosition(x, y);
               Console.WriteLine("+");
               count++;
}

