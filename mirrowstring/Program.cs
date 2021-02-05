using System;

namespace mirrowstring
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int n;
            string stroka1, stroka2;
            string stroka1out = "";
            string stroka2out = "";
            string stroka1Vvod = Console.ReadLine();

             n = stroka1Vvod.Length;
             for (int i = 0; i < n; i++)
             {
                 stroka1 = stroka1Vvod.Substring(n - i - 1, 1);
                 stroka1out += stroka1;
             }
             Console.WriteLine(stroka1out);


            //part 2

            string stroka2Vvod = Console.ReadLine();
            string[] mass = stroka2Vvod.Split('/');
            int dlinamas = mass.Length;
            for (int j = 0; j < dlinamas; j++)
            {
                n = mass[j].Length;

                for (int i = 0; i < n; i++){ 
                    stroka2 = mass[j].Substring(n - i - 1, 1); 
                    stroka2out += stroka2;

                }
                if (j!=(dlinamas-1))
                { 
                    stroka2out += "/";
                }
                



            }
            Console.WriteLine(stroka2out);

        }
        

    }
}
