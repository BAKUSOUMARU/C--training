using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 今回は条件式「if文」についてやっていこうと思います
/// </summary>
namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();//この変数 r はC＃にあるランダムに数を出すための物です
            int x = r.Next(0, 265);
            //この変数 a はランダムに出す数の範囲を絞ってます
            //r　の後にある「.」(ドット)は○○の何かという役割を持ってます
            //Next(最小値,最大値)このようにして設定してます
            if (x % 2 == 0)
            {
                Console.WriteLine(x +"は偶数" );

            }
            else
            {
                Console.WriteLine(x + "は奇数" );
            }
            Console.ReadLine();
            
        }
    }
}
