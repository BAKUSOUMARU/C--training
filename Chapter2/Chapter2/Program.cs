using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //今回は前回やった変数を利用して計算をしていきます

            
            int a = 1 + 15;　//足し算。記号は「+」(プラス)です
            Console.WriteLine(a);
            
            int b = 15 - 5;　//引き算。記号は「-」(マイナス)です
            Console.WriteLine(b);

            int c = 20 * 15;　//掛け算。記号は「*」(アスタリスク)です
            Console.WriteLine(c);

            int d = 20 / 5;　//割り算。記号は「/」(スラッシュ)です
            Console.WriteLine(d);

            int e = 13 % 2;　//剰余算。記号は「％」(パーセント)です
            Console.WriteLine(e); 
            //剰余算なんとなく使い方説明～
            //剰余算は使いところどこだよと言われそうなのでなんとなくで説明します
            //剰余算は割り算の余りを求める式です
            //使いどころは数が偶数か奇数かを求めたりするときに使います！
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //***練習1***
            //変数名answerを宣言して式の答えが20になる式を作りましょう
            //変数とコンソールに出す処理は下の空白の欄に書いてください
            int answer = 15 + 5;
            Console.WriteLine(answer);
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //文字列 + 文字列をすると文字列を合わせることができます
            string f = "あいうえお";
            string g = "かきくけこ";
            Console.WriteLine(f + g);
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //***練習2***
            //変数ｙとDayを利用して100日目と出力しましょう
            //空白の行にコンソールに出すコードを書いてください
            int y = 100;
            string Day = "日目";
            Console.WriteLine(y + Day);
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();
            //特殊な書き方
            int x = 0; //初めに変数xを宣言して数を0と決めた

            x++;//これは「x = x + 1」をしたのと同じことになります
            Console.WriteLine(x);

            x += 1;//これは「x = x + 1」をしたのと同じことになります
            Console.WriteLine(x);

            x += 10;//これは「x = x + 10」をしたのと同じことになります
            Console.WriteLine(x);
            
            
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();
            
            //下の空白は復習に利用してください
            //次回は条件式をやろうかな





        }
    }
}
