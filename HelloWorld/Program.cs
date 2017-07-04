/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： Program
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
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.ReadKey();
            //Rectangle rect = new Rectangle();
            //rect.Acceptdetails();
            //rect.Display();

            //ExplicitConversion ec = new ExplicitConversion();

            //double d = 223.23;

            //int i = ec.convertDouble2Int(d);

            //Console.WriteLine("类型强制转换：由double类型，值为{0}，转化为int类型，值为{1}", d,i);

            //转为字符串
            //StringConversion sc = new StringConversion();
            //Console.WriteLine("基本类型转为字符串事例：");
            //sc.toString();
            ////基本类型转换
            //sc.convert();

            //对象类型转换
            //ObjectConvert oc = new ObjectConvert();
            //oc.convertObject();

            ////常量定义
            //DeclaringConstants dc = new DeclaringConstants();
            //dc.Constants();

            //运算符
//             OperatorsAppl oa = new OperatorsAppl();
//             oa.operators();
// 
//             //算术运算符
//             oa.operators2();
//             //关系运算符
//             oa.operators3();
//             //逻辑运算符
//             oa.operators4();
// 
//             //位运算符
//             oa.operators5();
//             //其他运算符
//             oa.operators6();

            /* 局部变量定义 */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //调用 FindMax 方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}", ret);

            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    class Rectangle
    {
        //成员变量
        double length;
        double width;
        public void Acceptdetails() {
            length = 4.5;
            width = 3.5;
        }
        /**
         *计算面积 
         **/
        public double GetArea() {
            return width * length;
        }
        //显示面积数据
        public void Display() {
            Console.WriteLine("Length:{0}",length);
            Console.WriteLine("Width:{0}", width);

            Console.WriteLine("Area:{0}",this.GetArea());

        }
    }


}
