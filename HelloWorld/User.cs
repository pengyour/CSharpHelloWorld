/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： User
* 创建人：landy
* 创建时间：2017/7/5 9:24:11
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 9:24:11 landy 初版
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
/// 建造者模式的应用
/// </summary>
namespace HelloWorld
{
    class User
    {
        private String firstName;
        private String lastName;
        private int age;
        private String addr;
        private String phone;

        private User(UserBuilder builder)
        {
            this.firstName = builder.getFirstName();
            this.lastName = builder.getLastName();
            this.age = builder.getAge();
            this.phone = builder.getPhone();
            this.addr = builder.getAddr();
        }

        public class UserBuilder
        {
            private String firstName;
            private String lastName;
            private int age;
            private String addr;
            private String phone;

            public UserBuilder(String firstName, String lastName) {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public UserBuilder setAge(int age) {
                this.age = age;
                return this;
            }

            public UserBuilder setAddr(String addr)
            {
                this.addr = addr;
                return this;
            }

            public UserBuilder setPhone(String phone)
            {
                this.phone = phone;
                return this;
            }

            public User build()
            {
                Console.WriteLine("初始化User对象 firstName={0},lastName={1},age={2},addr={3},phone={4}", this.getFirstName() ,this.getLastName(),this.getAge(),this.getAddr(),this.getPhone());
                return new User(this);
            }

            public String getFirstName()
            {
                return this.firstName;
            }

            public String getLastName()
            {
                return this.lastName;
            }
            public int getAge()
            {
                return this.age;
            }

            public String getAddr()
            {
                return this.addr;
            }

            public String getPhone()
            {
                return this.phone;
            }

        }

        
    }
}
