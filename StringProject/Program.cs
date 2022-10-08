namespace StringProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello world";
            string s11 = "Hello world";
            string s2 = new String('-', 10);
            string s3 = new String(s1.ToCharArray(), 2, 5);

            string s4 = "Bob;Joe;Bill;Tom;Mike";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s1 == s11);

            Console.WriteLine($"Contains - {s1.Contains("ll")}");
            Console.WriteLine("Contains - {0}", s1.Contains("ll"));
            Console.WriteLine($"Concat - {String.Concat(s1, " Hello people")}");
            Console.WriteLine($"EndsWith - {s1.EndsWith("ld")}");

            Console.WriteLine($"{100}");

            var strarr = s4.Split(';');
            foreach (var s in strarr)
                Console.Write(s + " ");
            Console.WriteLine();

            var s5 = String.Join('+', strarr);
            s5 = s5.PadLeft(s5.Length + 10,'$');
            Console.WriteLine(s5);
        }
    }
}