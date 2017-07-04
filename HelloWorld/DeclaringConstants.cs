/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： DeclaringConstants
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
    class DeclaringConstants
    {
        public void Constants()
        {
            /*
            字符常量是括在双引号 "" 里，或者是括在 @"" 里。字符串常量包含的字符与字符常量相似，可以是：普通字符、转义序列和通用字符
            使用字符串常量时，可以把一个很长的行拆成多个行，可以使用空格分隔各个部分。
            这里是一些字符串常量的实例。下面所列的各种形式表示相同的字符串。
            */
            string a = "hello, world";                  // hello, world
            string b = @"hello, world";               // hello, world
            string c = "hello \t world";               // hello     world
            string d = @"hello \t world";               // hello \t world
            string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
            string f = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
            string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
            string h = @"\\server\share\file.txt";      // \\server\share\file.txt
            string i = "one\r\ntwo\r\nthree";
            string j = @"one two three";

            Console.WriteLine("常量定义事例：");
            Console.WriteLine("字符串常量：a={0},b={1},c={2},d={2},e={3},f={4},g={5},h={6},i={7},j={8}",a,b,c,d,e,f,g,h,i,j);

            //整数常量可以是十进制、八进制或十六进制的常量。前缀指定基数：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。
            //整数常量也可以有后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。后缀可以是大写或者小写，多个后缀以任意顺序进行组合。
            //212 ;        /* 合法 */
            //215u        /* 合法 */
            //0xFeeL      /* 合法 */
            //078         /* 非法：8 不是一个八进制数字 */
            //032UU       /* 非法：不能重复后缀 */

            //一个浮点常量是由整数部分、小数点、小数部分和指数部分组成。您可以使用小数形式或者指数形式来表示浮点常量。
            //这里有一些浮点常量的实例：
            //3.14159       /* 合法 */
            //314159E-5L    /* 合法 */
            //510E          /* 非法：不完全指数 */
            //210f          /* 非法：没有小数或指数 */
            //.e55          /* 非法：缺少整数或小数 */
            const double pi = 3.14159; // 常量声明
            double r;
            Console.WriteLine("浮点数常量事例：");
            Console.WriteLine("Enter Radius(请输入半径，计算面积): ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);

        }
    }
}
