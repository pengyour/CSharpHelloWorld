/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： operatorsappl
* 创建人：LANDY
* 创建时间：2017-7-4 10:29:38
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017-7-4 LANDY 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：厦门卫生检疫技术研究所 　　　　　　　　　　　　　　     │
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class OperatorsAppl
    {

        //************************************
        // Method:    operators
        // FullName:  HelloWorld.OperatorsAppl.operators
        // Access:     public 

        // Returns:   void
        // Qualifier:
        //************************************

        public void operators()
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;

            Console.WriteLine("运算符事例：a={0},b={1}",a,b);

            Console.WriteLine("Line 1 - a+b=c 的值是 {0}", c);

            c = a - b;
            Console.WriteLine("Line 2 - c = a - b 的值是 {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c = a * b 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c = a / b 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c = a % b 的值是 {0}", c);

            // ++a 先进行自增运算再赋值
            c = ++a;
            Console.WriteLine("Line 6 - c = ++a 的值是 {0}", c);

            // 此时 a 的值为 22
            // --a 先进行自减运算再赋值
            c = --a;
            Console.WriteLine("Line 7 - c = --a 的值是 {0}", c);
        }

        public void operators2()
        {
            int a = 1;
            int b;
            Console.WriteLine("算数运算符事例。。。");

            // a++ 先赋值再进行自增运算
            b = a++;
            Console.WriteLine("a++ 先赋值再进行自增运算,a = {0}", a);
            Console.WriteLine("a++ 先赋值再进行自增运算,b = {0}", b);

            // ++a 先进行自增运算再赋值
            a = 1; // 重新初始化 a
            b = ++a;
            Console.WriteLine("++a 先进行自增运算再赋值,a = {0}", a);
            Console.WriteLine("++a 先进行自增运算再赋值,b = {0}", b);

            // a-- 先赋值再进行自减运算
            a = 1;  // 重新初始化 a
            b = a--;
            Console.WriteLine("a-- 先赋值再进行自减运算,a = {0}", a);
            Console.WriteLine("a-- 先赋值再进行自减运算,b = {0}", b);

            // --a 先进行自减运算再赋值
            a = 1;  // 重新初始化 a
            b = --a;
            Console.WriteLine("--a 先进行自减运算再赋值,a = {0}", a);
            Console.WriteLine("--a 先进行自减运算再赋值,b = {0}", b);
        }

        public void operators3()
        {
            int a = 21;
            int b = 10;

            Console.WriteLine("算数运算符事例,a={0},b={1}",a,b);

            if (a == b)
            {
                Console.WriteLine("Line 1 - a 等于 b");
            }
            else
            {
                Console.WriteLine("Line 1 - a 不等于 b");
            }
            if (a < b)
            {
                Console.WriteLine("Line 2 - a 小于 b");
            }
            else
            {
                Console.WriteLine("Line 2 - a 不小于 b");
            }
            if (a > b)
            {
                Console.WriteLine("Line 3 - a 大于 b");
            }
            else
            {
                Console.WriteLine("Line 3 - a 不大于 b");
            }
            /* 改变 a 和 b 的值 */
           
            a = 5;
            b = 20;
            Console.WriteLine("算数运算符事例,改变a和b的值，a={0},b={1}", a, b);
            if (a <= b)
            {
                Console.WriteLine("Line 4 - a 小于或等于 b");
            }
            if (b >= a)
            {
                Console.WriteLine("Line 5 - b 大于或等于 a");
            }
        }
        /**
         * 逻辑运算符
         */ 
        public void operators4()
        {
            bool a = true;
            bool b = true;
            Console.WriteLine("逻辑运算符事例,a={0},b={1}", a, b);
           

            if (a && b)
            {
                Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - 条件为真");
            }
            /* 改变 a 和 b 的值 */
            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - 条件为真");
            }
        }

        public void operators5()
        {

        }

    }
}
