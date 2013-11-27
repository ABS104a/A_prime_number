using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_A_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("limit of a prime number?");
            int limit_num = Int32.Parse(Console.ReadLine()) + 2;

            //ざる用の配列を作成
            bool[] flagArray = new bool[limit_num];

            //配列の初期化
            for (int i = 0; i < limit_num; i++)
            {
                flagArray[i] = true;
            }

            //ふるいにかける
            for (int i = 2; i < limit_num; i++)
            {
                int j_count = 2;
                for (int j = i * j_count; j < limit_num; j = i * j_count)
                {
                    //数字のn倍（n > 1）は素数では無いので除外する。
                    flagArray[j] = false;
                    j_count++;
                }
            }

            //結果出力
            int result = 0;
            for (int i = 2; i < limit_num; i++)
            {
                if (flagArray[i] == true)
                {
                    Console.WriteLine(++result + " : " + i);
                }
            }
            Console.WriteLine("Result = " + result);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
