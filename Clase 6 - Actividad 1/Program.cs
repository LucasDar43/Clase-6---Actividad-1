namespace actividad1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la primer cadena de texto");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda cadena de texto");
            string cadena2 = Console.ReadLine();

            string cadena3 = InterleavingStrings(cadena1, cadena2);

            Console.WriteLine("La cadena intercalada es: {0}", cadena3);

        }

        private static string InterleavingStrings(string cadena1, string cadena2)
        {
            int longitudCadena1 = cadena1.Length;
            int longitudCadena2 = cadena2.Length;
            int longitudCadena3 = longitudCadena1 + longitudCadena2;
            int indiceCadena1 = 0;
            int indiceCadena2 = 0;

            char[] caracteresCadena1 = cadena1.ToCharArray();
            char[] caracteresCadena2 = cadena2.ToCharArray();
            char[] caracteresCadena3 = new char[longitudCadena3];

            for (int i = 0; i < longitudCadena3; i++)
            {
                if (i % 2 == 0 && indiceCadena1 < longitudCadena1)
                {
                    caracteresCadena3[i] = caracteresCadena1[indiceCadena1];
                    indiceCadena1++;
                }
                else if (indiceCadena2 < longitudCadena2)
                {
                    caracteresCadena3[i] = caracteresCadena2[indiceCadena2];
                    indiceCadena2++;
                }
            }

            return new string(caracteresCadena3);
        }
    }
}
