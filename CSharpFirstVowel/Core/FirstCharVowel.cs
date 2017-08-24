using System;

namespace CSharpFirstVowel.Core
{
    public class FirstCharVowel
    {
        #region Variables

        /// <summary>
        /// Vogais
        /// </summary>
        private static char[] _vowels = { 'a', 'e', 'i', 'o', 'u'};

        #endregion

        #region Methods
        
        /// <summary>
        /// Encontra primeira vogal que não se repete após uma consoante na stream informada.
        /// </summary>
        /// <param name="input">Stream para ser analisada.</param>
        /// <returns>Retorna '0' caso não exista resultado.</returns>
        public static char FirstChar(IStringStream input)
        {
            string result = string.Empty;
            char[] foundVowels = { };
            int index = 0;
            char currentChar;
            char previousChar = '\0';

            /* Lopping percorrendo o array da stream */
            while (input.HasNext())
            {
                /* Obtém o caracter corrente */
                currentChar = input.GetNext();

                /* Verifica se é uma vogal */
                if (Array.IndexOf(_vowels, currentChar) != -1)
                {
                    /* Verifica se a vogal é repetida */
                    if (Array.IndexOf(foundVowels, currentChar) != -1)
                    {
                        /* Confirma se o resultado parcial é valido */
                        if (result == currentChar.ToString())
                            result = string.Empty;
                    }
                    else
                    {
                        /* Incremento o array com a vogal encontrada */
                        Array.Resize(ref foundVowels, foundVowels.Length + 1);
                        foundVowels[foundVowels.Length - 1] = currentChar;

                        if (index > 0)
                        {
                            /* Verifica se o caracter anterior é consoante */
                            if (Array.IndexOf(_vowels, previousChar) == -1)
                            {
                                if (string.IsNullOrWhiteSpace(result))
                                    result = currentChar.ToString();
                            }
                        }
                    }
                }

                /* Armazena o caracter anterior para a próxima iteração */
                previousChar = currentChar;
                index++;
            }

            return (string.IsNullOrWhiteSpace(result) ? '0' : Convert.ToChar(result));
        }        

        #endregion
    }
}