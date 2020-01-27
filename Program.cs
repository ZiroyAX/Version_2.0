﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    public class Program
    {

        public static bool checkNum(string str)
        {
            int n;
            bool check = int.TryParse(str, out n);

            if (check)
            {
                return true;
            }
            else return false;
        }




        ////////////////////////////Задание 1       
        public static int[] sortArr()
        {

            int tmp = 0;
            int tmp2 = 0;
            int tmp3 = 0;

            long maxValue = -9223372036854775808;
            long minValue = 9223372036854775807;

            char[] gg = { ' ', ',', ':', ';' };
            int[] ar;
            int temp_counter = 0;
            int temp_counter_exit = 0;

            Console.WriteLine("Введите массив чисел через пробел");
            do
            {
                temp_counter = 0;
                string str = Console.ReadLine();

                string[] strArr = str.Split(gg, StringSplitOptions.RemoveEmptyEntries);
                temp_counter_exit = strArr.Length;

                //Проверка на число
                foreach (string e in strArr)
                {
                    if (checkNum(e))
                    {
                        temp_counter++;
                    }
                }

                //Console.WriteLine(temp_counter + " " + strArr.Length);

                //Копирование массива с преобразованием типа
                if (temp_counter == temp_counter_exit)
                {
                    ar = new int[strArr.Length];
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        ar[i] = int.Parse(strArr[i]);
                        //Console.WriteLine("ar[i]= " + ar[i] + " " + "strArr[i]= " + strArr[i]);


                    }



                    //Сортировка
                    for (int s = 0; s < ar.Length; s++)
                    {

                        for (int j = 1; j < ar.Length; j++)
                        {
                            tmp = ar[j - 1];
                            tmp2 = ar[j];

                            if (tmp > maxValue)
                            {
                                maxValue = tmp;
                            };
                            if (tmp < minValue)
                            {
                                minValue = tmp;
                            };

                            if (tmp > tmp2)
                            {
                                tmp3 = tmp2;
                                ar[j] = tmp;
                                ar[j - 1] = tmp3;
                            }

                        }

                    }
                    /*
                                    for (int i = 0; i < ar.Length; i++)
                                    {
                                            Console.WriteLine("i= " + i + " - " + ar[i]);
                                    }
                    */
                    Console.WriteLine("Минимальное значение= " + minValue);
                    Console.WriteLine("Максимальное значение= " + maxValue);


                    return ar;

                }
                else Console.WriteLine("Введите, пожалуйста, целые числа не превышающие максимальный размер типа int: +-2 147 483 647");

            } while (temp_counter != temp_counter_exit);


            int[] end = { 0 };
            return end;
        }




        ////////////////////////////////////////////////////Задание 2

        public static int Search_ver1(int[] h)
        {
            Console.WriteLine("Введите число, которое хотите найти:");
            int searc;
            string string_searc;

            do
            {
                string_searc = Console.ReadLine();
                if (checkNum(string_searc))
                {
                    searc = int.Parse(string_searc);
                    for (int i = 0; i < h.Length; i++)
                    {
                        if (searc == h[i])
                        {
                            //Console.WriteLine("Найден под индексом: " + i);
                            return i;
                        }
                    }

                }
                else Console.WriteLine("Введите, пожалуйста, целое число");



            } while (checkNum(string_searc) != true);

            return 12345004;
        }


        public static int Search_ver2(int[] h, int k)
        {
            int left = 0;
            int right = h.Length - 1;
            int mid = 0;

            //int temp = 0;

            while (left <= right)
            {
                //temp++;

                mid = (left + right) / 2;

                //Console.WriteLine("left= " + left);
                //Console.WriteLine("right= " + right);
                //Console.WriteLine("mid= " + mid + " temp= " + temp);

                if (k == h[mid])
                {
                    Console.WriteLine("Найден! под индексом v2 " + mid);
                    //Console.WriteLine("k1= " + k +" " + h[mid]);
                    break;
                }

                if (k < h[mid])
                {
                    right = mid - 1;
                    //Console.WriteLine("k2= " + k + "<" + "m= " + h[mid] + "--" + (k < h[mid]));
                }

                if (k > h[mid])
                {
                    left = mid + 1;
                    //Console.WriteLine("k3= " + k + ">" + "m= " + h[mid] + "--" + (k > h[mid]));
                }
            }

            if (left > right)
            {
                Console.WriteLine("Число не найдено v2");
            }


            return mid;
        }



        ////////////////////////////////////////////////////////////////Задание 4

        public static long Factorial_ver1(int n)
        {


            //int n = int.Parse(Console.ReadLine());



            int[] counter_n = new int[n];
            long counter_all = 1;

            for (int i = 0; i < n; i++)
            {
                counter_n[i] = i + 1;
                //Console.WriteLine("i= " + i + " " + counter_n[i]);
            }


            for (int i = 0; i < counter_n.Length; ++i)
            {
                counter_all = counter_all * counter_n[i];
                //Console.WriteLine("counter_all= " + counter_all + " " + "counter_n= " + counter_n[i]);
            }

            return counter_all;
        }

        public static long Factorial_ver2(int n)
        {

            long counter_all = 1;

            for (int i = 0; i < n; ++i)
            {
                counter_all = counter_all * (i + 1);
            }

            return counter_all;
        }






        static void Main(string[] args)
        {




            /**********************************************************************************************************************
             * 
             * Задание №1
             * 
             **********************************************************************************************************************/
            //sortArr();
            
            int[] hhh = sortArr();

            foreach (int i in hhh)
            {
                Console.WriteLine(i);
            }
            
            /********************************************************************************************************************
             * 
             * Конец кода
             * 
             *******************************************************************************************************************/



            /**********************************************************************************************************************
            * 
            * Задание №2
            * 
            **********************************************************************************************************************/
            
            int temp_search_1 = Search_ver1(hhh);
            if (temp_search_1 == 12345004)
            {
                Console.WriteLine("Число не найдено v1");
            }
            else Console.WriteLine("Найден под индексом v1: " + temp_search_1);



            Console.WriteLine("Версия поиска 2: Введите целое число");
            string string_number_searc;
            int number_searc = 0;
            do
            {
                string_number_searc = Console.ReadLine();
                if (checkNum(string_number_searc))
                {
                    number_searc = int.Parse(string_number_searc);
                }
                else Console.WriteLine("Ошибка, введите число");
            } while (checkNum(string_number_searc) != true);

            int temp_search_2 = Search_ver2(hhh, number_searc);

            
            /**********************************************************************************************************************
            * 
            * Конец кода
            * 
            **********************************************************************************************************************/



            /**********************************************************************************************************************
            * 
            * Задание №3
            * 
            **********************************************************************************************************************/
            
            Console.WriteLine("Введите предложение: ");

            string str_2 = Console.ReadLine();

            string[] arrSTR = str_2.Split(' ');
            //Console.WriteLine(arrSTR.Length);



            for (int i = 0; i < arrSTR.Length; i++)
            {
                int s = 0;
                string temp_i = arrSTR[i];

                //Console.WriteLine("i= " + i + arrSTR[i]);
                for (int k = 0; k < arrSTR.Length; k++)
                {
                    //Console.WriteLine("k= " + k + arrSTR[k]);

                    string temp_k = arrSTR[k];
                    if (temp_i == temp_k)
                    {
                        s++;
                    }
                }
                if (s <= 1)
                {
                    Console.WriteLine("Найдены уникальные слова: " + arrSTR[i]);
                }
            }

            
            /**********************************************************************************************************************
            * 
            * Конец кода
            * 
            **********************************************************************************************************************/


            /**********************************************************************************************************************
            * 
            * Задание №4
            * 
            **********************************************************************************************************************/

            

            Console.WriteLine("Введите число для нахождения его факториала: ");
            string str4;
            int n;


            do
            {
                str4 = Console.ReadLine();

                if (checkNum(str4))
                {
                    n = int.Parse(str4);
                    Console.WriteLine("Факториал версия 1: " + Factorial_ver1(n));
                    Console.WriteLine("Факториал версия 2: " + Factorial_ver2(n));

                }
                else Console.WriteLine("Ошибка, введите, пожалуйста, целое число");
            }

            while (checkNum(str4) != true);


            

            /**********************************************************************************************************************
            * 
            * Конец кода
            * 
            **********************************************************************************************************************/



            /**********************************************************************************************************************
            * 
            * Задание №5
            * 
            **********************************************************************************************************************/

            string[] psp = { "(","(", "{", "(", ")", "}", "(", ")", ")", ")" };

            string p1 = "()";
            string p2 = "{}";

            var psp_open = new Stack<string>();
            //Stack<string> psp_exit = new Stack<string>();


            //Проверка на четность и открытие/закрытие
            //Console.WriteLine(psp.Length % 2 == 0);
            //Console.WriteLine(((psp[0] + psp[psp.Length - 1]) == p1) || ((psp[0] + psp[psp.Length - 1]) == p2));

            if ((psp.Length % 2 == 0) && (((psp[0] + psp[psp.Length - 1]) == p1) || ((psp[0] + psp[psp.Length - 1]) == p2)))
            {



                for (int i = 0; i < psp.Length; i++)
                {
                    if ((psp[i] == "(") || (psp[i] == "{"))
                    {
                        psp_open.Push(psp[i]);
                        //Console.WriteLine("open шаг= " + i);
                    }

                    if (psp[i] == ")" || psp[i] == "}")
                    {
                        string tmp_open = psp_open.Peek();
                        //Console.WriteLine("tmp_open= " + tmp_open);
                        string tmp_sum = tmp_open + psp[i];
                        //Console.WriteLine("tmp_sum= " + tmp_sum);


                        if ((tmp_sum == p1) || (tmp_sum == p2))
                        {
                            psp_open.Pop();
                        }

                    }


                }

                if (psp_open.Count == 0)
                {
                    Console.WriteLine("Правильная");
                }
                else
                {
                    Console.WriteLine("Не правильная");
                }
                /*
                foreach (string e in psp_open)
                {
                    Console.WriteLine(e + "e");
                }
                */
            } else Console.WriteLine("Не правильная");








            Console.WriteLine("Haжмитe <Enter> для выхода . . . ");
            Console.Read();
        }
    }
}

