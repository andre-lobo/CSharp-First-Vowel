namespace CSharpFirstVowel.Core
{
    public interface IStringStream
    {
        /// <summary>
        /// Obtém o próximo caracter do array da stream.
        /// </summary>
        /// <returns></returns>
        char GetNext();

        /// <summary>
        /// Retorna se existe um próximo caracter no array da stream.
        /// </summary>
        /// <returns></returns>
        bool HasNext();
    }
}
