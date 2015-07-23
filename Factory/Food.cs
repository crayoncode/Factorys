using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 菜的抽象类
    /// </summary>
     public abstract class Food
    {
         /// <summary>
         /// 输出点了什么菜
         /// </summary>
         public abstract void Print();
    }
}
