using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            // 变量声明（将x,y,a,b定义为整数型）
            int x, y, a, b;

            // Assignment operator
            // 赋值运算符
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There are many mathematical operators ...
            // 下面还有更多数学的运算符...

            // Addition operator
            // 加法运算符
            x = 3 + 4;

            // Subtraction operator
            // 减法运算符
            x = 4 - 3;

            // Multiplication operator
            // 乘法运算符
            x = 10 * 5;

            // Division operator
            // 除法运算符
            x = 10 / 5;

            // Order of operations using parenthesis
            //圆括号控制运算的顺序
            x = (x + y) * (a - b);

            // There are many operators used to evaluate values ...
            // 下面有更多的评估运算符

            // Equality operator
            // 等号运算符，“==”用来判断两项是否相等，判断真伪
            if (x == y) //此处的等号定义表达式“x==y”的边界
            {
            }

            // Greater than operator
            // 大于运算符
            if (x > y)
            {
            }

            // Less than operator
            // 小于运算符
            if (x < y)
            {
            }

            // Greater or equal to operator
            // 大于等于运算符
            if (x >= y)
            {
            }

            // Less than or equal to operator
            // 小于等于运算符
            if (x <= y)
            {
            }


            // There are two "conditional" operators as well that can be used to expand / enhance an evaluation ...
            // 两个条件运算符可以扩大或增强评估
            // ... and they can be combined together multiple times.
            // 并且可以多次组合使用

            // Conditional AND operator … 
            // 条件运算符和“AND”运算符结合，"&&"可以换成"AND"
            if ((x > y) && (a > b)) // 意思是：x > y 且 a > b（二者同时满足）
            {
            }

            // Conditional OR operator …
            // 条件运算符和“OR”运算符结合, "||"可以换成"OR"
            if ((x > y) || (a > b)) // 意思是：x > y 或 a > b（二者满足其中任意一个）
            {
            }

            // Also, here's the in-line conditional operator we 
            // 同样的，在这里有内联条件运算符":"
            // learned about in the previous lesson ...
            // 在前面的课程学过
            string message = (x == 1) ? "Car" : "Boat"; //":"意思是，如果条件满足圆括号内的，输出（执行）冒号前面的，否则执行冒号后面的

            // Member access and Method invocation
            // 成员访问和方法调用
            Console.WriteLine("Hi");
            // "."叫做成员访问运算符，目的是访问"Console"类中的成员"WriteLine"
            // "()"叫做方法调用运算符，目的是调用"WriteLine"这个方法

            /*                     总结
             * 语句是C#中的完整指令，由表达式构成
             * 一个表达式由操作数,运算符组成
             * 操作数可以使一串字符,变量，对象或类（Class,比如Console）
             * 运算符比如数学运算符（加减乘除）,条件运算符（if之类的）,赋值运算符“=”
             * 表达式（C#语句）用来构建想法，完成你想做的事情
             * 一个表达式也就是C#语句就是你编写的应用程序的操作或指令如何由编译器编译
               并交由".Net运行时(.Net Runtime)"执行的体现
            */

            x + y; // 这是一个无效表达式，因为未对x和y定义
                   // 红色波浪线指出了问题的所在，将光标放到上面可以显示详细问题
                   // 详细问题说的是：只有赋值,调用,递增,递减和新的对象表达式才能当做C#语句

        }
    }
}
