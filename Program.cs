using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Задание 1. Вывести на экран число e");
                double x = Math.E;
                Console.WriteLine("E={0:F1}", x);
            

            
                Console.WriteLine("Задание 2. ");
                Console.WriteLine(50 + "\n" + 10);
            


          
                Console.WriteLine("Задание 3. 4 числа в столбик");
                Console.WriteLine("Введите любые 4 цифры");
                int[] ints = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                foreach (int l in ints)
                {
                    Console.WriteLine(l + "\n");
                }
            

            
                Console.WriteLine("Задание 4. Число + 10");
                Console.WriteLine("Введите любое число");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 10);
            

            Console.WriteLine("Задание 5. Периметр квадрата");
            Console.WriteLine("Введите сторону квадрата");
            int jam = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр квадрата равен:");
            Console.WriteLine(jam * 4);

            Console.WriteLine("Задание6");
            Console.WriteLine("Введите радиус круга");
            int lam = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности равна:"); 
            Console.WriteLine(Math.Round(lam * 2 * Math.PI));
            Console.WriteLine("Площадь круга равна:");
            Console.WriteLine(Math.Round(lam * lam * Math.PI));

            Console.WriteLine("Задание7");
            Console.WriteLine("Введите значение Х");
            int ham = int.Parse(Console.ReadLine());
            Console.WriteLine("Косинус равен:" + Math.Cos(ham));

            Console.WriteLine("Задание8");
            Console.WriteLine("Введите значение высоты");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение верхнего основания");
            int  a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение нижнего основания");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр равен: " + (Math.Sqrt(Math.Pow((b - a) / 2, 2) + Math.Pow(h, 2))) * 2 + a + b);

            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите вес ваших покупок через пробел (конфеты, печенье, яблоки)\r\nБудем считать, что цены такие: яблоки - 100р; конфеты - 200р; печенье - 300р");
            double[] products = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
            Console.WriteLine("Итоговая стоимость: " + (products[0] * 200 + products[1] * 300 + products[2] * 100));

            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир" + "\n" + "\t" + "Труд" + "\n" + "\t" + "\t" + "Май");

            Console.WriteLine("Задание 11");
            Console.Write("Введите число A = ");
            string c = Console.ReadLine();
            Console.Write("Введите число B = ");
            string d = Console.ReadLine();

            string checkedA = checkText(c); //Проверка на соответствие
            string checkedB = checkText(d); //Проверка на соответствие

            if (checkedA.Length > 0 && checkedB.Length > 0)
            {
                Console.WriteLine("A = {0}, B = {1}", checkedA, checkedB);
                Console.WriteLine("Перетасовочка...");
                string newA = checkedB;
                string newB = checkedA;
                Console.WriteLine("A = {0}, B = {1}", newA, newB);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

        private static string checkText(string text)
        {
            char[] chars = text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsNumber(chars[i]))
                {
                    sb.Append(chars[i]);
                }
                else if (chars[i] == '.' || chars[i] == ',')
                {
                    if (sb.ToString().Split('.').Length - 1 == 0)
                    {
                        sb.Append('.');
                    }
                    // раскомментировать если нужно убрать символы после повторения разделителя
                   
                }
                else
                {
                    return "";
                }
            }
            return sb.ToString();

            Console.WriteLine("Задание 12");
            Console.Write("треугольник = 1, четырехугольник = 2, круг = 3\nВыберите фигуру:");
            string figure = Console.ReadLine();
            Console.Write("площадь = 1, периметр = 2\nВыберите что необходимо считать:");
            string type = Console.ReadLine();

            switch (figure)
            {
                case "1":
                    Console.WriteLine($"Результаты треугольника: \n{checkTriangle(type)}");
                    break;
                case "2":
                    Console.WriteLine($"Результаты четырехугольника: \n{checkQuadr(type)}");
                    break;
                case "3":
                    Console.WriteLine($"Результаты круга: \n{checkCircle(type)}");
                    break;
            }
        }

        private static string checkTriangle(string type)
        {
            double sum = 0.0;
            string selectType = "";
            if (type == "1")
            {    //площадь
                selectType = "Площадь";
                Console.Write("Введите высоту: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите основание: ");
                double a = Convert.ToDouble(Console.ReadLine());
                sum = 0.5 * (a * h);
            }
            else if (type == "2")
            { //периметр
                selectType = "Периметр";
                Console.Write("Введите сторону A: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону Z: ");
                double z = Convert.ToDouble(Console.ReadLine());
                sum = a + b + z;
            }
            return Convert.ToString($"{selectType} = {sum}");
        }

        private static string checkCircle(string type)
        {
            double sum = 0.0;
            string selectType = "";
            if (type == "1")
            {    //площадь
                selectType = "Площадь";
                Console.Write("Введите радиус: ");
                double r = Convert.ToDouble(Console.ReadLine());
                sum = Math.PI * Math.Pow(r, 2);
            }
            else if (type == "2")
            { //периметр
                selectType = "Периметр";
                Console.Write("Введите радиус: ");
                double r = Convert.ToDouble(Console.ReadLine());
                sum = 2 * Math.PI * r;
            }
            return Convert.ToString($"{selectType} = {sum}");
        }

        private static string checkQuadr(string type)
        {
            double sum = 0.0;
            string selectType = "";
            if (type == "1")
            {    //площадь
                selectType = "Площадь";
                Console.Write("Введите угол между диагоналями: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите диагональ d1: ");
                double d1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите диагональ d2: ");
                double d2 = Convert.ToDouble(Console.ReadLine());
                sum = 0.5 * d1 * d2 * Math.Sin((Math.PI * a) / 180);
            }
            else if (type == "2")
            { //периметр
                selectType = "Периметр";
                Console.Write("Введите сторону A: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                double g = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону V: ");
                double v = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону Z: ");
                double z = Convert.ToDouble(Console.ReadLine());
                sum = a + g + v + z;
            }
            return Convert.ToString($"{selectType} = {sum}");


            Console.WriteLine("задание 12. площади фигур");
            Console.WriteLine("выберите фигуру (0 - треугольник / 1 - четырёхугольник / 2 - круг)");
            int vvodF = int.Parse(Console.ReadLine());
            if (vvodF == 0)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS1 = int.Parse(Console.ReadLine());
                if (vvodPS1 == 0)
                {
                    Console.WriteLine("введите значения трёх сторон треугольника через пробел");
                    int[] vvod1 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("периметр равен: " + (vvod1[0] + vvod1[1] + vvod1[2]));
                }
                else
                {
                    Console.WriteLine("введите значения трёх сторон треугольника через пробел");
                    int[] vvod2 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("площадь равна: " + Math.Sqrt(((vvod2[0] + vvod2[1] + vvod2[2]) / 2) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[0]) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[1]) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[2])));
                }
            }
            if (vvodF == 1)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS2 = int.Parse(Console.ReadLine());
                if (vvodPS2 == 0)
                {
                    Console.WriteLine("введите значения сторон четырёхугольника через пробел");
                    int[] vvod3 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("периметр равен: " + 2 * (vvod3[0] + vvod3[1]));
                }
                else
                {
                    Console.WriteLine("введите значения сторон четырёхугольника через пробел");
                    int[] vvod4 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("плоащадь равна: " + (vvod4[0] * vvod4[1]));
                }
            }
            if (vvodF == 2)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS3 = int.Parse(Console.ReadLine());
                if (vvodPS3 == 0)
                {
                    Console.WriteLine("введите значение радиуса круга");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("периметр равен: " + Math.Round(2 * (rad * Math.PI)));
                }
                else
                {
                    Console.WriteLine("введите значение радиуса круга");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("плоащадь равна: " + Math.Round(Math.PI * Math.Pow(rad, 2)));
                }
            }

            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine($"вы ввели число {e}");

            
            Console.WriteLine("Задание 14. 2 kg");
            string[] arr = { "2 кг", "13 17" };
            Console.WriteLine(arr[0] + "\n" + arr[1]);

            Console.WriteLine("Задание 15. Рандомные числа в столбик ");
            var rando = new Random();
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine($"{rando.Next(1000)}");
            }
                Console.WriteLine("задание 16. квадратное уравнение");
            Console.WriteLine("Введите первый коэфицент(A)");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэфицент(B)");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэфицент(C)");
            int C = int.Parse(Console.ReadLine());
            int D = Convert.ToInt32(Math.Sqrt(B * B - 4 * A * C));// нашли кв корень из дискриминанта
            Console.WriteLine("Первый корень:" + (-B + D) / 2 * A);
            Console.WriteLine("второй корень:" + (-B - D) / 2 * A);

            Console.WriteLine("задание 17. ср. арифметическое и геометрическое ");
            Console.WriteLine("Введите первое число");
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int ch2 = int.Parse(Console.ReadLine());
            Console.WriteLine("среднее арифметическое: " + (ch1 + ch2) / 2 + "\n" + "среднее геометрическое: " + Math.Sqrt(ch1 * ch2));

            Console.WriteLine("задание 18. расстояние между точками");
            Console.WriteLine("введите координаты первой точки через пробел(x , y)");
            int[] xy1 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();//задаёт массив разбивая строку по пробелам и вызывает для каждого символа int.Parse 
            Console.WriteLine("введите координаты второй точки через пробел(x , y)");
            int[] xy2 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Расстояние между точками: " + Math.Sqrt(Math.Pow((xy2[0] - xy1[0]), 2) + Math.Pow((xy2[1] - xy1[1]), 2))); //задаём формулу расстояния между точками

            Console.WriteLine("задание 19. замена значений переменных");
            int f = 1;
            int b = 2;
            int c1 = 3;
            int t = 1;
            Console.WriteLine($"f = {f}  b = {b}  c = {c1}");
            t = b;
            b = c1;
            c1 = f;
            f = t;
            Console.WriteLine($"пункт А: f = {f}  b = {b}  c = {c1}");
            f = 1;
            b = 2;
            c1 = 3;
            t = 1;
            t = b;
            b = f;
            f = c1;
            c1 = t;
            Console.WriteLine($"пункт Б: f = {f}  b = {b}  c = {c1}");

            Console.WriteLine("задание 20. секунды");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("прошло часов: " + sec / (60 * 60));
            Console.WriteLine("прошло полных минуt с начала очередного часа: " + ((sec / 60) - ((sec / 60) / 60) * 60));
            Console.WriteLine("прошло секунд с начала последней минуты: " + sec % 60);

            Console.WriteLine("задание 21. прямоугольник");
            Console.WriteLine("Можно вырезать " + (543 / 130) + " квадратов");

            Console.WriteLine("задание 22. меняем цифры в трёхзначном числе");
            Console.WriteLine("введите трёхначное число");
            int inpt = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inpt % 10}{inpt / 10}");

            Console.WriteLine("задание 23. сотни и ты сячи в четырёхзначном числе ");
            Console.WriteLine("введите число > 999");
            int inpt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a) число сотен: " + (inpt1 / 100) % 10);
            Console.WriteLine("b) число тысяч: " + (inpt1 / 1000));

            Console.WriteLine("задание 24. меняем цифры в четырёхзначном числе");
            Console.WriteLine("введите число > 999");
            string inpt2 = Console.ReadLine();
            string outpt2 = "";
            for (int t1 = inpt2.Length - 1; t1 >= 0; t1--)
            {
                outpt2 += inpt2[t1];
            }
            Console.WriteLine("a) " + outpt2);
            if ((int.Parse(inpt2) / 100) % 10 == 0)
            {
                Console.WriteLine("b) " + inpt2[0] + inpt2[2] + inpt2[3]);
            }
            else
            {
                Console.WriteLine("b) " + inpt2[1] + inpt2[0] + inpt2[2] + inpt2[3]);
            }
            Console.WriteLine("c) " + inpt2[0] + inpt2[2] + inpt2[1] + inpt2[3]);
            if ((int.Parse(inpt2) / 10) % 10 == 0)
            {
                Console.WriteLine("d) " + inpt2[3] + inpt2[0] + inpt2[1]);
            }
            else
            {
                Console.WriteLine("d) " + inpt2[2] + inpt2[3] + inpt2[0] + inpt2[1]);
            }
            Console.WriteLine("задание 25.");
            Console.WriteLine("введите число 100 <= n =< 999");
            string inpt3 = Console.ReadLine();
            if ((int.Parse(inpt3) / 10) % 10 == 0)
            {
                Console.WriteLine("введите другое число");
            }
            else
            {
                Console.WriteLine("x = " + inpt3[1] + inpt3[2] + inpt3[0]);
            }
            Console.WriteLine("задание 26.");
            Console.WriteLine("Введите время: часы, минуты, секунды по очереди");
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (hour > 11)
            {
                hour -= 12;
            }
            Console.WriteLine("cейчас угол между положением стрелки на началr дня и временем ввреденным вами равен: " + ((360 / 12) * hour + (0.5 * minutes) + (0.0083 * seconds)));


            Console.WriteLine("задание 28. меньшее из трёх по мудулю");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] abs2 = { Math.Abs(abs[0]), Math.Abs(abs[1]), Math.Abs(abs[2]) };
            Console.WriteLine("меньшее из трёх: " + abs2.Min());

            Console.WriteLine("задание 29. сумма наибольшего и наименьшего их трёх");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs3 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("сумма наибольшего и наименьшего : " + (abs3.Min() + abs3.Max()));

            Console.WriteLine("задание 30. количество делителей натурального числа");
            Console.WriteLine("Введите целое число");
            int count = 0;
            int val;
            if (Int32.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Делители числа" + val);
                for (int m = 1; m <= val; m++)
                    if (val % m == 0)
                    {
                        count++;
                    }
                Console.WriteLine("Количество делителей числа " + val + " : " + count);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("введите число!!");

            }
            Console.WriteLine("задание 31. кубическое уравнение");
            Console.WriteLine("введите коэффициенты уравнения (a,b,c,d)");
            int[] coef = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            for (int otr = -100; otr <= 100; otr++)
            {
                double result = coef[0] * Math.Pow(otr, 3) + coef[1] * otr * otr + coef[2] * otr + coef[3];
                if (result == 0)
                {
                    Console.WriteLine("X = " + otr);
                }
            }

            Console.WriteLine("задание 32");
            Console.WriteLine("Введите первый элемент последовательности");
            double seq1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности");
            double seq2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
            double NumOfSeq = double.Parse(Console.ReadLine());
            double elemen = seq1 + ((seq2 - seq1) * (NumOfSeq - 1));
            Console.WriteLine($"Элемент последовательности с номером {NumOfSeq} равен {elemen}");

            Console.WriteLine("задание 33. кредит в банке");
            Console.WriteLine("Дайте ответы на вопросы");
            Console.WriteLine("Являетесь ли вы пенсионером? (1 - да / 0 - нет)");
            int pensioners = int.Parse(Console.ReadLine());
            Console.WriteLine("Являетесь ли вы студентом? (1 - да / 0 - нет)");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы тродоустроены? (1 - да / 0 - нет)");
            int yn = int.Parse(Console.ReadLine());
            if (((pensioners == 1 && yn == 0) || (student == 1 && yn == 0)) && (pensioners == 0 || student == 0))
            {
                Console.WriteLine("Поздравляю вам одобрен кредит)");
            }
            else
            {
                Console.WriteLine("Кредит не одобрен, сожалею(");
            }
            Console.WriteLine("задание 34. имя человека");
            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"a) {name}");
            Console.WriteLine("введите имя");
            string name2 = Console.ReadLine();
            Console.WriteLine($"б) Привет, {name2}!");

            Console.WriteLine("задание 35. разговор Гарри и дневника");
            Random color = new Random();
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name3 = Console.ReadLine();
            Console.WriteLine($"Пивет, {name3}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            int color1 = color.Next(1, 15);
            if (color1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (color1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            if (color1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (color1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            if (color1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (color1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            if (color1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (color1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (color1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            if (color1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (color1 == 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (color1 == 11)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            if (color1 == 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (color1 == 13)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (color1 == 14)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (color1 == 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine("задание 36.1(рандомные цифры). EAN13");
            int[] array = new int[13];
            Random rand = new Random();
            for (int y = 0; y < 13; y++)
            {
                array[y] = rand.Next(0, 10);
            }
            array[12] = 0;
            int sum = 0;
            int i = 1;
            while (i < 13)//вычисляем сумму цифр на чётных позициях 
            {
                sum = sum + array[i];
                i = i + 2;
            }
            int sum1 = 0;
            int j = 0;
            while (j < 13)//вычисляем сумму цифр на нечётных позициях 
            {
                sum1 = sum1 + array[j];
                j = j + 2;
            }
            int temp;
            for (temp = (sum1 + sum * 3); temp < 100; temp++)
            {
                if (temp % 10 == 0)
                {
                    Console.WriteLine("контрольная цифра: " + (temp - (sum1 + sum * 3)));// выводим контрольную цифру
                    break;
                }
            }
            Console.WriteLine("задание 36.2(вводит пользователь). EAN13");
            int[] arrayc = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int q = 0; q < 12; q++)
            {
                arrayc[q] = int.Parse(Console.ReadLine());
            }
            int sum3 = 0;
            int i1 = 1;
            while (i < 13)//вычисляем сумму цифр на чётных позициях 
            {
                sum3 = sum3 + arrayc[i];
                i1 = i1 + 2;
            }
            int sum2 = 0;
            int j1 = 0;
            while (j < 13)//вычисляем сумму цифр на нечётных позициях 
            {
                sum1 = sum1 + arrayc[j];
                j1 = j1 + 2;
            }
            int temp2;
            for (temp2 = (sum2 + sum3 * 3); temp2 < 100; temp2++)
            {
                if (temp2 % 10 == 0)
                {
                    Console.WriteLine("контрольная цифра: " + (temp2 - (sum2 + sum3 * 3)));// выводим контрольную цифру
                    break;
                }
            }




            Console.ReadKey();





        }
    }
}
