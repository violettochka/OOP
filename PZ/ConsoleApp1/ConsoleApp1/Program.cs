namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element element = new Element();
            element.Appearence = "&";
            element.Name = "Ampersand";

            Console.Write(element.Appearence);
            Console.WriteLine(element.Name);

            Element[,] matrix = new Element[10, 10];

            //заповнюємо матрицю
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Element();
                    matrix[i, j].Appearence = "&";
                    matrix[i, j].Name = "Ampersand";
                }
            }
            //Виводимо на консоль елементи матриці
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(matrix[i, j].Appearence);
                    Console.WriteLine(matrix[i, j].Name);
                }
            }



        }
    }
}
