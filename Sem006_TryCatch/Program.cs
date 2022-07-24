namespace Seminar6
{
    class Program
    {
        public static void Main(string[] args)
        {
            try // (Пробовать)
            {
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);
            }
            catch 
            {
                Console.Write("Вы ввели неправильные данные");  //throw new Exception(); // throw (можно попробовать выкинут исключение самостоятельно).
            }
        }
    }
}
