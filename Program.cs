using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.");
            Console.WriteLine("Merhaba Hello Question.");
    
            string cumle = "Merhaba Hello Question.";
            string yeniCumle = "";
            string harfTutucu = "";
            for (int i = 0; i <= cumle.Length; i++)
            {
                if ((i == 0)||(cumle[i-1].ToString() == " "))
                {
                    harfTutucu = cumle[i].ToString();                    
                }
                else if (i == cumle.Length)
                {
                    yeniCumle += harfTutucu;
                }                
                else if (cumle[i].ToString() == " ")
                {
                    yeniCumle += harfTutucu + " ";
                    
                }
                else
                {
                    yeniCumle += cumle[i].ToString();
                }
            }
            Console.WriteLine(yeniCumle);
        
            
            
        }

        
    }
}
