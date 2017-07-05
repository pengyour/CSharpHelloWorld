/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： Rectangle
* 创建人：landy
* 创建时间：2017/7/5 8:41:24
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 8:41:24 landy 初版
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
    class Rectangle

    {
        //成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        /**
         *计算面积 
         **/
        public double GetArea()
        {
            return width * length;
        }
        //显示面积数据
        public void Display()
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Width:{0}", width);

            Console.WriteLine("Area:{0}", this.GetArea());

        }

    }
}
