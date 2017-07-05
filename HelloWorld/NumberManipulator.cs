/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： NumberManipulator
* 创建人：landy
* 创建时间：2017/7/4 16:55:15
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/4 16:55:15 landy 初版
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

    class NumberManipulator
    {

        //************************************
        // Method:    FindMax
        // FullName:  HelloWorld.NumberManipulator.FindMax
        // Access:     public 

        // Returns:   int
        // Qualifier: 求两个数中更大的值
        // Parameter: int num1
        // Parameter: int num2
        //************************************
        public int FindMax(int num1, int num2)
        {
            /* 局部变量声明 */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        //************************************
        // Method:    factorial
        // FullName:  HelloWorld.NumberManipulator.factorial
        // Access:     public 

        // Returns:   int
        // Qualifier: 递归方法调用
        // Parameter: int num
        //************************************
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        //************************************
        // Method:    swap
        // FullName:  HelloWorld.NumberManipulator.swap
        // Access:     public 

        // Returns:   void
        // Qualifier: 这是参数传递的默认方式。在这种方式下，当调用一个方法时，会为每个值参数创建一个新的存储位置。
        // 实际参数的值会复制给形参，实参和形参使用的是两个不同内存中的值。所以，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全
        // Parameter: int x
        // Parameter: int y
        //************************************
        public void swap(int x, int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        //************************************
        // Method:    swapByRef
        // FullName:  HelloWorld.NumberManipulator.swapByRef
        // Access:     public 

        // Returns:   void
        // Qualifier:引用参数是一个对变量的内存位置的引用。当按引用传递参数时，与值参数不同的是，它不会为这些参数创建一个新的存储位置。
        // 引用参数表示与提供给方法的实际参数具有相同的内存位置。
        // 在 C# 中，使用 ref 关键字声明引用参数。
        // Parameter: ref int x
        // Parameter: ref int y
        //************************************
        public void swapByRef(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        //************************************
        // Method:    getValue
        // FullName:  HelloWorld.NumberManipulator.getValue
        // Access:     public 
        // Returns:   void
        // Qualifier: return 语句可用于只从函数中返回一个值。但是，可以使用 输出参数 来从函数中返回两个值。
        // 输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。
        // Parameter: out int x
        //************************************
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        //************************************
        // Method:    getValues
        // FullName:  HelloWorld.NumberManipulator.getValues
        // Access:     public 

        // Returns:   void
        // Qualifier: 提供给输出参数的变量不需要赋值。当需要从一个参数没有指定初始值的方法中返回值时，输出参数特别有用。
        // Parameter: out int x
        // Parameter: out int y
        //************************************
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
