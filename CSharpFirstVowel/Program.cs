using System;
using CSharpFirstVowel.Core;

namespace CSharpFirstVowel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool repeat = true;

            Console.WriteLine("Aplicativo para encontrar a primeira vogal que não se repete após uma consoante.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine();

            while (repeat)
            {
                Console.WriteLine("Digite uma sequência de caracteres: ");
                string stream = Console.ReadLine();
                Console.WriteLine();

                var stringStream = new StringStream(stream);
                                
                var result = FirstCharVowel.FirstChar(stringStream);
                if (result != '0')
                {
                    Console.WriteLine(string.Format("Vogal encontrada: {0}", result));
                }
                else
                {
                    Console.WriteLine("Não foi encontrada vogais que atendam os requisitos.");
                }

                Console.WriteLine("Deseja executar novamente? [S/N]");
                repeat = Console.ReadLine().ToUpper() == "S" ? true : false;
                Console.WriteLine();
            }
        }
    }
}
