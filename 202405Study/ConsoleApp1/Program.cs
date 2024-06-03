//class Program
//{
//    static void Main()
//    {
//        int a = int.Parse(Console.ReadLine());

//        string[] bc = Console.ReadLine().Split(' ');
//        int b = int.Parse(bc[0]);
//        int c = int.Parse(bc[1]);

//        string str = Console.ReadLine();

//        Console.WriteLine($"{a + b + c} {str}");

//    }
//}

////class Program
////{
////    // ABC086A - Product　奇数か偶数か
////    static void Main()
////    {
////        string[] ab = Console.ReadLine().Split(' ');
////        int a = int.Parse(ab[0]);
////        int b = int.Parse(ab[1]);

////        string ret = ((a * b) % 2 == 0) ? "Even" : "Odd";

////        Console.WriteLine(ret);

////    }
////}

////class Program
////{
////    // ABC081A - Placing Marbles マス目3つのうち、１はいくつあるか
////    static void Main()
////    {
////        char[] masu = Console.ReadLine().ToCharArray();
////        var cnt = 0;
////        for (int i = 0; i < masu.Length; i++)
////        {
////            cnt = masu[i].ToString() == "1" ? cnt + 1 : cnt;
////        }
////        Console.WriteLine(cnt);
////    }
////}

////class Program
////{
////    // ABC081B - Shift only　全部偶数の時に２で割る操作を何回出来るか
////    static void Main()
////    {
////        int cnt = 0;
////        int strCnt = int.Parse(Console.ReadLine()); 
////        List<int> numList = GetIntList(Console.ReadLine().Split(" ").ToList());

////        while (numList.Where(m => m % 2 == 0).Count() == strCnt)
////        {
////            cnt++;
////            numList = GetEvenList(numList);
////        }
////        Console.WriteLine(cnt);
////    }

////    static List<int> GetIntList(List<string> lst)
////    {
////        return lst.Select(m => int.Parse(m)).ToList();
////    }

////    static List<int> GetEvenList(List<int> lst)
////    {
////        return lst.Select(m => m / 2).ToList();
////    }
////}


////class Program
////{
////    // ABC087B - Coins　複数種類の硬貨で特定の金額は何パターン作れるか
////    static void Main()
////    {
////        int cnt = 0;
////        int a = int.Parse(Console.ReadLine());
////        int b = int.Parse(Console.ReadLine());
////        int c = int.Parse(Console.ReadLine());
////        int x = int.Parse(Console.ReadLine());

////        for (int intA = 0; intA <= a; intA++)
////        {
////            for (int intB = 0; intB <= b; intB++)
////            {
////                for (int intC = 0; intC <= c; intC++)
////                {
////                    var total = 500 * intA + 100 * intB + 50 * intC;
////                    if (total == x) { cnt++; }
////                }
////            }
////        }

////        Console.WriteLine(cnt);
////    }
////}

////class Program
////{
////    // ABC083B - Some Sums　1以上N以下の整数でA<=〇<=Bになる整数の和
////    static void Main()
////    {
////        int total = 0;
////        string[] nab = Console.ReadLine().Split(" ");
////        int n = int.Parse(nab[0]);
////        int a = int.Parse(nab[1]);
////        int b = int.Parse(nab[2]);

////        for (int num = 1; num <=  n; num++)
////        {
////            int sum = GetKetanoWa(num);
////            if (sum >= a && sum <= b) {
////                total += num; ; 
////            }
////        }
////        Console.WriteLine(total);
////    }

////    static int GetKetanoWa(int num)
////    {
////        var ret = 0;
////        while(num > 0)
////        {
////            var amari = (num % 10);
////            ret += amari;
////            num /= 10;
////        }
////        return ret;
////    }
////}

////class Program
////{
////    // ABC088B - Card Game for Two　交互にカードを取った差
////    static void Main()
////    {
////        int cardCnt = int.Parse(Console.ReadLine());
////        List<string> strCard = Console.ReadLine().Split(" ").ToList();
////        List<int> cardList = strCard.Select(m => int.Parse(m)).ToList();
////        cardList = cardList.OrderByDescending(m => m).ToList();

////        int alice = 0;
////        int bob = 0;

////        for (int i = 0; i < cardCnt; i++)
////        {
////            if (i % 2 == 0)
////            {
////                alice += cardList[i];
////                continue;
////            }

////            bob += cardList[i];
////        }

////        var ret = alice - bob;
////        Console.WriteLine(ret);
////    }
////}

////class Program
////{
////    // ABC085B - Kagami Mochi 最大何段の鏡餅が作れるか
////    static void Main()
////    {
////        int mochiCnt = int.Parse(Console.ReadLine());
////        List<int> mochiList = new List<int>();
////        for (int i = 0; i < mochiCnt; i++)
////        {
////            mochiList.Add(int.Parse(Console.ReadLine()));
////        }
////        mochiList = mochiList.Distinct().ToList();

////        Console.WriteLine(mochiList.Count());
////    }
////}

////class Program
////{
////    // ABC085C - Otoshidama　お年玉の枚数と金額が言ったとおりになるかどうか
////    static void Main()
////    {
////        string[] ny = Console.ReadLine().Split(" ");
////        int maisuu = int.Parse(ny[0]);
////        int totalKingaku = int.Parse(ny[1]);
////        string ret = "-1 -1 -1";

////        for (int cnt10000 = 0; cnt10000 <= maisuu; cnt10000++)
////        {
////            for (int cnt5000 = 0; cnt5000 <= maisuu; cnt5000++)
////            {
////                int cnt1000 = maisuu - cnt10000 - cnt5000;
////                if (cnt1000 < 0) { continue; }

////                if(10000 * cnt10000 + 5000 * cnt5000 + 1000 * cnt1000 == totalKingaku 
////                    && cnt10000 + cnt5000 + cnt1000 == maisuu)
////                {
////                    ret = $"{cnt10000} {cnt5000} {cnt1000}";
////                    break;
////                }
////            }
////        }

////        Console.WriteLine(ret);
////    }
////}

//class Program
//{
//    // ABC049C - 白昼夢　
//    static void Main()
//    {
//        List<string> list = new List<string> { "dream", "dreamer", "erase", "eraser" };
//        string s = Console.ReadLine();
//        string t = string.Empty;

//        s = s.Reverse().ToString();

//        Console.WriteLine(ret);
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string[] s = Console.ReadLine().Split(" ");
//        int n = int.Parse(s[0]);
//        int m = int.Parse(s[1]);

//        int total = 15 * n + 5 * m;

//        Console.WriteLine(total);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int kingaku = int.Parse(Console.ReadLine());
//        int ret = -1;

//        for (int int100 = 0; int100 <= 9999; int100++)
//        {
//            for (int int500 = 0; int500 <= 9999; int500++)
//            {
//                var total = 500 * int500 + 100 * int100;
//                if(total > kingaku) { break; }
//                if (total == kingaku) 
//                {
//                    ret = int500 + int100;
//                    Console.WriteLine(ret);
//                    return;
//                }
//            }
//        }
//        Console.WriteLine(ret);
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        int toshiCnt = int.Parse(Console.ReadLine());
//        List<string> toshiLstStr = Console.ReadLine().Split(" ").ToList();
//        List<int> toshiLst = toshiLstStr.Select(m => int.Parse(m)).ToList();
//        int minToshi = toshiLst[0];
//        int total = 0;

//        foreach(var toshi in toshiLst)
//        {
//            if(toshi < minToshi)
//            {
//                minToshi = toshi;
//            }

//            total += minToshi;
//        }

//        Console.WriteLine(total);
//    }
//}

class Program
{
    static void Main()
    {
        string[] lst = Console.ReadLine().Split(" ");
        int junin = int.Parse(lst[0]);
        junin = junin * 2;
        int uwasa = int.Parse(lst[1]);
        int nissuu = 0;
        int uwasaHasei = uwasa;
        List<string> retStr = new List<string>();

        List<int> juninLst = new List<int>();
        for (int i = 1; i <= junin; i++)
        {

            juninLst.Add(i);
        }

        // 日数
        while (junin > uwasaHasei)
        {
            GetHanashi(nissuu, uwasaHasei, juninLst);
            uwasaHasei += uwasaHasei;
            nissuu++;
        }

        Console.WriteLine(nissuu);
    }

    static string GetHanashi(int nissuu, int uwasaHasei, List<int> juninLst)
    {
        int temp;
        for(int i = 0; i < uwasaHasei; i++)
        {
            temp = juninLst[i];
            juninLst[i] = juninLst[i + uwasaHasei];
            juninLst[i + uwasaHasei] = temp;
        }
        for(int j = uwasaHasei * 2; j < juninLst.Count; j++)
        {
            temp = juninLst[j];
            juninLst[j] = juninLst[j + 1];
            juninLst[j + 1] = temp;
            j += 2;
        }
        return String.Join(" ", juninLst);
    }
}

