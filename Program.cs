namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taş, kağıt ve makas değerlerinden birini alabilir
            string oyuncu1, oyuncu2;

            Console.Write("Oyuncu 1'in seçimi nedir? ");
            oyuncu1 = Console.ReadLine();

            Console.Write("Oyuncu2'nin seçimi nedir? ");
            oyuncu2 = Console.ReadLine();

            //oyuncu 1 taş seçmişse
            if(oyuncu1 == "taş")
            {
                if (oyuncu2 == "makas")
                    Console.WriteLine("Oyuncu1 kazandı");
                else if(oyuncu2 == "kağıt")
                    Console.WriteLine("Oyuncu2 kazandı");
                else
                    Console.WriteLine("Berabere");
            }
            else if(oyuncu1 == "makas") //oyuncu1 makas seçmişse
            {
                if (oyuncu2 == "makas")
                    Console.WriteLine("Berabere");
                else if(oyuncu2 == "kağıt")
                    Console.WriteLine("Oyuncu1 kazandı");
                else
                    Console.WriteLine("Oyuncu2 kazandı");
            }
            else //oyuncu1 kağıt seçmişse
            {
                if (oyuncu2 == "makas")
                    Console.WriteLine("Oyuncu1 kazandı");
                else if (oyuncu2 == "kağıt")
                    Console.WriteLine("Berabere");
                else
                    Console.WriteLine("Oyuncu1 kazandı");
            }
        }
    }
}