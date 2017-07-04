/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： VariableDefinition
* 创建人：landy
* 创建时间：2017/7/4 8:16:46
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/4 8:16:46 landy 初版
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
    class VariableDefinition
    {
        /**
         * 正确地初始化变量是一个良好的编程习惯，否则有时程序会产生意想不到的结果。
         */
        public void VariableDef()
        {
            short a;
            int b;
            double c;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
