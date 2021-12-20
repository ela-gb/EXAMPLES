// Вывести квадрат числа
// int a = 2;
// Console.WriteLine(a*a);
// По двум заданным числам проверять является ли первое квадратом второго
// int a = 7;
// int b = 2;
// if (b*b==a)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//    Console.WriteLine("Первое число не является квадратом второго");  
// }
// Даны два числа. Показать большее и меньшее число
// int a = 7;
// int b = 50;
// if (a > b)
// {
//     Console.WriteLine(a + " Первое число большее, " + b + " Второе число меньшее ");
// }
// else
// {
//     Console.WriteLine(b + " Второе число большее,  " + a + " Первое число меньшее ");
// }

// По заданному номеру дня недели вывести его название

// int a = 5;
// if (a==1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// if (a==2)
// {
//     System.Console.WriteLine("Вторник");
// }
// if (a==3)
// {
//     System.Console.WriteLine("Среда");
// }
// if (a==4)
// {
//     System.Console.WriteLine("Четверг");
// }
// if (a==5)
// {
//     System.Console.WriteLine("Пятница");
// }
// if (a==6)
// {
//     System.Console.WriteLine("Суббота");
// }
// if (a==7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// Найти максимальное из трех чисел
// int a = 6;
// int b = 3;
// int c = 10;
// int max = a;
// if (b>max) max=b;
// if (c>max) max=c;
// System.Console.WriteLine(max);
// Написать программу вычисления значения функции y = f(a)

// int a = 2;
// System.Console.WriteLine(a*a*a*a*a);


// Выяснить является ли число чётным
// int a = 7;
// if (a%2==0)
// {
//     System.Console.WriteLine("Число четное");
// }
// else
// {
//     System.Console.WriteLine("Число не четное");
// }

// Показать числа от -N до N

// int N =3;
// int count = - N;
// while (count <=N)
// {
//     System.Console.WriteLine(count);
//     count=count+1;
// }


// Показать четные числа от 1 до N
// int N =10;
// int count = 1;
// while (count <=N)
// {
//     if (count%2==0)
//     System.Console.WriteLine(count);
//     count=count+1;
// }

// Показать последнюю цифру трёхзначного числа

// int a = 367;
// System.Console.WriteLine(a%10);

// Показать вторую цифру трёхзначного числа

// int a = 367;
// System.Console.WriteLine((a%100-a%10)/10);

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int a = 85;
// int b = a % 10;
// int c = (a - b) / 10;
// if (b > c)
// {
//     System.Console.WriteLine(b);
// }
// else
// {
//     System.Console.WriteLine(c);
// }
// Удалить вторую цифру трёхзначного числа
// int a = 962;
// int b = (a-(a % 100))/10;
// int c = a%10;
// System.Console.WriteLine(b+c);

// Выяснить, кратно ли число заданному, если нет, вывести остаток.

// int a = 46;
// int b = 5;
// if (a % b == 0)
// {
//     System.Console.WriteLine("Кратно");
// }
// else
// {
//     System.Console.WriteLine(a%b);
// }
// Найти третью цифру числа или сообщить, что её нет
// int a = new Random().Next(0, 10000);
// System.Console.WriteLine(a);

// if (a / 10 >= 100)
// {
//     System.Console.WriteLine(((a % 100) - (a % 10)) / 10);
// }

// else
// {
//     System.Console.WriteLine("третьей цифры нет");
// }


