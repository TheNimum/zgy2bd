using System;

namespace zgy2bd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett ord: ");
            String Word = Console.ReadLine();
            string rev = string.Empty;
            
            
            
            for(int i = Word.Length -1; i>=0; i-- ){
                
                rev += Word[i];

               

            }
              Console.WriteLine(rev);
            


            


        }
    }
}
            


            




            
                
            

            

            
            


