

using Modeller;
using Markalar;






namespace Araba_galerisi1
{
    public class program
    {
        private static bool endApp;

        static void Main(string[] args)
        {
            bool endApp = false;
           
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                
                Marka marka = new Marka()
                {
                    marka1 = "Toyota ---> Marka kodu 'T' ",
                    marka2 = "Mercedes--->Marka kodu 'M'",
                    marka3 = "Volkswagen---> Marka kodu 'W'",
                    marka4 = "Bmw--->Marka kodu 'B'",
                    marka5 = "Fiat---> Marka kodu 'F'"

                };
                Console.WriteLine("Markalarımız \n Marka:1 {0} \n Marka:1 {1} \n Marka:1 {2} \n Marka:1 {3} \n Marka:1 {4}" , marka.marka1,marka.marka2,marka.marka3,marka.marka4,marka.marka5);
                Console.WriteLine("--------------------------\n");
                Console.WriteLine("Lütfen Bir Marka Kodu Giriniz");

                string Marka1 = Console.ReadLine();
                string markaToyota = "T";
                string marka1 = "Toyota";
                string Marka2 = Console.ReadLine();
                string markaMercedes = "M";
                string marka2 = "Mercedes";
                string Marka3 = Console.ReadLine();
                string markaVolkswagen = "W";
                string marka3 = "Volkswagen";
                string Marka4 = Console.ReadLine();
                string markaBmw = "B";
                string marka4 = "Bmw";
                string Marka5 = Console.ReadLine();
                string markaFiat = "F";
                string marka5 = "Fiat";


                if (Marka1 == markaToyota)
                {
                    Console.WriteLine($"Seçtiğiniz marka :  {marka1}");
                }
                else if (Marka2 == markaMercedes)
                {
                    Console.WriteLine("Seçtiğiniz marka :  " + (marka2));
                }
                else if (Marka3 == markaVolkswagen)
                {
                    Console.WriteLine($"Seçtiğiniz marka :  {marka3}");
                }
                else if (Marka4 == markaBmw)
                {
                    Console.WriteLine("Seçtiğiniz marka : {0}", marka4);
                }
                else if (Marka5 == markaFiat)
                {
                    Console.WriteLine($"Seçtiğiniz marka :  {marka5}");
                }
                else
                {
                    Console.WriteLine("------------------------\n");


                    Console.Write("Tekrar denemek için herhangi bir tuşa basın Veya programı Sonlandırmak için 'y' tuşuna basın ");
                    if (Console.ReadLine() == "y") endApp = true;

                    Console.WriteLine("\n");
                }

                //if  (Marka1==markaToyota)
                //{
                //    Console.WriteLine($"Seçtiğiniz marka :  {marka1}");
                //    if else (Marka2 == markaMercedes)
                //    {
                //        Console.WriteLine("Seçtiğiniz marka : {0} " + (marka2));
                //        if (Marka3 == markaVolkswagen)
                //        {
                //            Console.WriteLine($"Seçtiğiniz marka :  {marka3}");
                //            if (Marka4 == markaBmw)
                //            {
                //                Console.WriteLine("Seçtiğiniz marka : {0}", marka4);
                //                if (Marka5 == markaFiat)
                //                {
                //                    Console.WriteLine($"Seçtiğiniz marka :  {marka}");
                //                }
                //            }
                //        }
                //    }
                //}
                //Console.Write("Tekrar denemek için herhangi bir tuşa basın Veya programı Sonlandırmak için 'y' tuşuna basın ");
                //if (Console.ReadLine() == "y") endApp = true;

                Console.WriteLine("\n");
                Model model = new()
                {
                    model1 = "HatchBag ---> Model kodu 'H'",
                    model2 = "Sedan ---> Model kodu 'S'",
                    model3 = "Limo ---> Model kodu 'L'",
                };
                Console.WriteLine("Model Seçeneklerimiz; \n Model1 :{0} \n  Model2 :{1} \n  Model3 :{2}", model.model1, model.model2, model.model3);



                Console.WriteLine("Lütfen bir model kodu giriniz");
                string Model1 = Console.ReadLine();
                string modelhatchbag = "H";
                string model1 = "HatchBag";
                string Model2 = Console.ReadLine();
                string modelSedan = "S";
                string model2 = "Sedan";
                string Model3 = Console.ReadLine();
                string modelLimo = "L";
                string model3 = "Limo";

                if (Model1 == modelhatchbag)
                {
                    Console.WriteLine("Seçtiğiniz model : {0} ", (model1));
                }
                else if (Model2 == modelSedan)
                {
                    Console.WriteLine("Seçtiğiniz model :  " + (model2));
                }
                else if (Model3 == modelLimo)
                {
                    Console.WriteLine($"Seçtiğiniz model : {model3}");
                }
                else
                {
                    Console.WriteLine("Yanlış bir kod girdiniz ");
                    Console.WriteLine("------------------------\n");


                    Console.Write("Tekrar denemek için herhangi bir tuşa basın Veya programı Sonlandırmak için 't' tuşuna basın ");
                    if (Console.ReadLine() == "t") endApp = true;

                    Console.WriteLine("\n");

                }
                Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz");
                Console.WriteLine("\n");
                Console.Write("Programı Sonlandırmak için 'a' tuşuna,Devam etmek için klavyenizden herhangi bir tuşa basabilirsiniz ");
                    if (Console.ReadLine() == "a") endApp = true;

                  

              
                



            }
        }
    }
}
