// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("bir sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("doğru bir sayı giriniz");
    Console.WriteLine("hata:" + ex.Message.ToString());
    
}
finally
{
    Console.WriteLine("işlem tamam");

}