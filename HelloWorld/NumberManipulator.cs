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
    }
}
