namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 
             *Modificador Ref 
             *
            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);
            **/

            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
