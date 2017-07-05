/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： MyString
* 创建人：landy
* 创建时间：2017/7/5 9:17:32
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 9:17:32 landy 初版
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
/// <summary>
/// 在 C# 中，您可以使用字符数组来表示字符串，但是，更常见的做法是使用 string 关键字来声明一个字符串变量。string 关键字是 System.String 类的别名。
/// 您可以使用以下方法之一来创建 string 对象：
// 通过给 String 变量指定一个字符串
// 通过使用 String 类构造函数
// 通过使用字符串串联运算符（ + ）
// 通过检索属性或调用一个返回字符串的方法
// 通过格式化方法来转换一个值或对象为它的字符串表示形式
/// </summary>
namespace HelloWorld
{
    class MyString
    {
        public void StringDemo() {
            //字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",
            waiting);
            //String 类有许多方法用于 string 对象的操作
            string[] starray = new string[]{"Down the way nights are dark",
             "And the sun shines daily on the mountain top",
             "I took a trip on a sailing ship",
             "And when I reached Jamaica",
             "I made a stop"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);

            str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);

            str = "This is test";
            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            Console.WriteLine("Message: {0}", chat);
        }
    }
}
