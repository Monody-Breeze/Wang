namespace git测试项目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("program.cs添加了输出语句");
        }
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public double Mul(double a, double b)
        {
            return a * b; 
        }
        public double Div(double a, double b)
        {
            return a / b;

        }
    }
}