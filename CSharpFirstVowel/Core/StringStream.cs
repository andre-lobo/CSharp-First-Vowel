namespace CSharpFirstVowel.Core
{
    public class StringStream : IStringStream
    {
        #region Variables

        /// <summary>
        /// Array de char da stream recebida no construtor.
        /// </summary>
        private char[] _stream;

        /// <summary>
        /// Posição atual no array de char da stream.
        /// </summary>
        private int _indexOf = 0;

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor da classe StringStream.
        /// </summary>
        /// <param name="stream">String para ser percorrida.</param>
        public StringStream(string stream)
        {
            /* Garantir que todos os caracteres estão em minúsculo */
            _stream = stream.ToLower().ToCharArray();
        }

        #endregion

        #region Interface Implementation
        /// <summary>
        /// Obtém o próximo caracter do array da stream.
        /// </summary>
        /// <returns></returns>
        public char GetNext()
        {
            var value = _stream[_indexOf];
            _indexOf++;

            return value;
        }

        /// <summary>
        /// Retorna se existe um próximo caracter no array da stream.
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return _stream.Length > _indexOf;
        }

        #endregion
    }
}
