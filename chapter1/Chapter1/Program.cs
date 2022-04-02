using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        //F5を押すか上にある再生ボタンでプログラミングコードを実行することが可能です
        //この中にプログラミングコードを書くと使うことが可能になります
        static void Main(string[] args)
        {
            //Console.WriteLine().Console.Write()この2つはコンソールに文字を映すことができるコードです
            //この２つの違いは文字を改行できるかできないかの違いです(Console.WriteLine()の方が使う頻度は高いです(体感))
            //プログラミングの最後書いている（；）これはセミコロンと言い一つのコードを書き終えた時に書かれる物です
            //(主はセミコロンをよく忘れています（直さないとな～）)
            Console.Write("こんばんは!");
            Console.Write("こんばんは!");
            Console.WriteLine("こんばんは！");
            Console.WriteLine("こんばんは！");

            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //ここからはプログラミングの基礎の変数をやって行きます
            //変数とは、
            //数や文字などを保管するものいわば箱です
            //この箱はどこかで呼ぶ(開封)ことをしない限りは使われないです
            //変数を使う使うには初めに宣言(入れる箱を用意)しなければ使えません
            //変数を宣言するには初めに型と言う変数に入れる値の種類を決めないと行けません
            //型　その変数(箱)の名前；//このようにして宣言します

            int a;//int型は(整数)を保管することができます

            string b;//string型は(文字)を保管することが可能です

            //宣言した変数(箱)のなかに整数や文字を入れて行きましょう

            a = 200;
            b = "こんばんは！"; //文字を入れる時は（”）ダブルコーテーションを使いましょう(使わないとエラーが出ます)

            //宣言した変数(箱)を呼びましょう
            //宣言した変数を使う方法は()の中に変数(箱)の名前を書くだけです
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //ちなみに変数はこういう書き方もできます
            //基本的に自分はこう書いてます
            int c = 500;
            string d = "おはよう";

            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();
            //ここから下は今やったことの復習などに使用してください
            //次回は計算をやろうかな(予定)






        }
    }
}
