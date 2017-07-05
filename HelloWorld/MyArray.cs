/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： MyArray
* 创建人：landy
* 创建时间：2017/7/5 9:12:28
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 9:12:28 landy 初版
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
/// 数组是一个存储相同类型元素的固定大小的顺序集合。数组是用来存储数据的集合，通常认为数组是一个同一类型变量的集合。
//声明数组变量并不是声明 number0、number1、...、number99 一个个单独的变量，而是声明一个就像 numbers 这样的变量，然后使用 numbers[0]、numbers[1]、...、numbers[99] 来表示一个个单独的变量。数组中某个指定的元素是通过索引来访问的。
// 所有的数组都是由连续的内存位置组成的。最低的地址对应第一个元素，最高的地址对应最后一个元素。
/// </summary>
namespace HelloWorld
{
    class MyArray
    {
        public void myArrayDemo() {
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            int i, j;


            /* 初始化数组 n 中的元素 */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* 输出每个数组元素的值 */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
        }
        /// <summary>
        /// 我们使用一个 for 循环来访问每个数组元素。您也可以使用一个 foreach 语句来遍历数组。
        /// </summary>
        public void myArrayDemoByForEach()
        {
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */


            /* 初始化数组 n 中的元素 */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* 输出每个数组元素的值 */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }

    }
}
