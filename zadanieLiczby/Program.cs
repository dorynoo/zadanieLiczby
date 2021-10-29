using System;

namespace zadanieLiczby
{
    class Program
    {
        static bool Czy_jest_liczbą_pierwszą(int liczba)
        {
            if (liczba == 2)
            {
                return true;
            }
            if (liczba <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;



        }

        static void wypisz_n_liczb_pierwszych(int n)
        {
            int licznik = 0;
            int iterator = 0;
            Console.WriteLine("zacznij od nowa");
            while (licznik < n)
            {
                if (Czy_jest_liczbą_pierwszą(iterator))
                {
                    Console.WriteLine(iterator);
                    licznik++;

                }
                iterator++;


            }
        }
        static void Main(string[] args)
        {
            int liczby_pierwsze = Convert.ToInt32(Console.ReadLine());
            wypisz_n_liczb_pierwszych(liczby_pierwsze);
        }
    }
}
        


                

            


        
        
    
