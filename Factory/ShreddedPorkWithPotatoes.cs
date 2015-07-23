using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes:Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝好了");
        }
    }
}
