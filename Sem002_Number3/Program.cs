namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            string? number = Console.ReadLine();
            var str = number.ToString();
            if (99 < str && str < 1000) ;
            {
                int result = int.Parse(str.Remove(str.Length - 2, 1 ));
                Console.WriteLine(result);
            }
            else 
            Console.WriteLine("Неверный диапазон!");

        }



    }
}
