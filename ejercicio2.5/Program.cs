namespace ejerciciodoscinco
{

    public class lote
    {
        public static void Main()
        {
            decimal a, b, c, at, ar, ato;
            Console.WriteLine("Dijite la longitud de A");
            a=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Dijite la longitud de B");
            b=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Dijite la longitud de C");
            c=decimal.Parse(Console.ReadLine());
            ar = b * c;
            at = ((a - c) * b) / 2;
            ato = ar + at;
            Console.WriteLine($"El area calculada es : {ato}");
         }
    }
}