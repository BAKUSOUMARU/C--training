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
            

            int Answer1 = 1 + 15;　//足し算。記号は「+」(プラス)です
            Console.WriteLine(Answer1);

            int Answer2 = 15 - 5;　//引き算。記号は「-」(マイナス)です
            Console.WriteLine(Answer2);

            int Answer3 = 20 * 15;　//掛け算。記号は「*」(アスタリスク)です
            Console.WriteLine(Answer3);

            int Answer4 = 20 / 5;　//割り算。記号は「/」(スラッシュ)です
            Console.WriteLine(Answer4);

            int Answer5 = 13 % 2;　//剰余算。記号は「％」(パーセント)です
            Console.WriteLine(Answer5);
            //剰余算なんとなく使い方説明～
            //剰余算は使いところどこだよと言われそうなのでなんとなくで説明します
            //剰余算は割り算の余りを求める式です
            //使いどころは数が偶数か奇数かを求めたりするときに使います！
            Console.WriteLine("Enter キーを押すと次に進むことができてCtrl + C で実行をやめることができます");
            Console.ReadLine();

            //***練習1***
            //変数名answerを宣言して式の答えが20になる式を作りましょう
            //変数とコンソールに出す処理は下の空白の欄に書いてください


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
