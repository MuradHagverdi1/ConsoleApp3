using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            #region FindCharIndex
            //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve gonderilmis char deyeri
            //gonderilmis string deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir.
            //Misal ucun metodu call ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a' deyerlerini gondersek 0 qaytarmalidir
            //Bu metodu Main metodunda call edib isledeceksiniz.Metodu call ederken gondereceyiniz deyerleri Main metodunda console-dan istifadeci daxil etmelidir.

            //    Console.WriteLine("String dəyəri daxil edin");
            //    String Deyer = (Console.ReadLine());

            //    Console.WriteLine("Axtarilacaq char dəyəri daxil edin");
            //    char Axtarilan = char.Parse(Console.ReadLine());

            //    FindCharIndex(Deyer, Axtarilan);

            //}

            //static void FindCharIndex(string Deyer, char Axtarilan)
            //{
            //    bool yoxla = true;

            //    for (int i = 0; i < Deyer.Length; i++)
            //    {
            //        if (Deyer[i] == Axtarilan)
            //        {
            //            yoxla = true;
            //        }
            //    }

            //    if (yoxla == true)
            //    {
            //        Console.WriteLine("Axtarilan char tapildi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Axtarilan char tapilmadi");
            //    }
            #endregion

            #region IsPrime
            //IsPrime metodu - parametr olaraq ineteger value qebul edir.
            //Gonderilims integer deyerin sade olub olmadigini qaytarir.
            //Eded sadedirse true, deyilse false qayitmalidir

            //Console.WriteLine("Parametr daxil edin");
            //string Parametr = Console.ReadLine();

            //int a = int.Parse(Parametr);

            //IsPrime(a);


            //static void IsPrime(int a)
            //{

            //    if (a == 0 || a == 1)
            //    {
            //        Console.WriteLine("false");

            //    }
            //    else
            //    {
            //        for (int i = 2; i <= a / 2; i++)
            //        {
            //            if (a % i == 0)
            //            {
            //                Console.WriteLine("false");
            //                return;
            //            }

            //        }
            //        Console.WriteLine("true");

            //    }




            //}
            #endregion

            #region CalcAvg

            //CalcAvg metodu - Gondeirlmis imtahanlar qiymeti siyahisina (integer array) esasen hemin qiymetlerin ortalamasini qaytaran metod yazin.
            //Main metodunda bu metodu call edib, burdan qayidan deyere esasen ortalama 60-dan boyukdursa console-da "mezun oldunuz" eks halda "mezun ola bilmediniz" yazisi yazdirin

           

            
           
            //int size;
            //Console.WriteLine("imtahanlarin sayini daxil edin");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($" {i+1} Imtahanin qiymetini daxil edin - ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
           

            //Average(arr);


            //static void Average (int[] arr)
            //{
            //    double result = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        result = result + arr[i];
            //    }

            //    result = result / arr.Length;

            //    if (result > 60)
            //    {
            //        Console.WriteLine($" {result} balla mezun oldunuz");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($" {result} balla mezun ola bilmediniz");
            //    }
                 
            //}



            #endregion






        }
    }
}


