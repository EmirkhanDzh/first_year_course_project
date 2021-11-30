using System;
namespace BridgesExceptionLib
{

    [Serializable]
    public class BridgesException : Exception
    {
        /// <summary>
        /// Конструктор умолчания.
        /// </summary>
        public BridgesException() { }
        /// <summary>
        /// Конструктор с одним параметром о сообщении об ошибке.
        /// </summary>
        /// <param name="message"></param>
        public BridgesException(string message) : base(message) { }
        /// <summary>
        /// Конструктор с двумя параметрами с информациями об ошибке.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public BridgesException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Конструктор с информацией об ошибке.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected BridgesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
