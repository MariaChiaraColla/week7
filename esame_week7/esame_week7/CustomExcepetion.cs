using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace esame_week7
{
    public class CustomExcepetion
    {
        //ridefinisco un eccezione, queste sono le righe minime da scrivere
        [Serializable] //attributo di tutta la classe
        public class CustomException : Exception
        {
            //costruttori, ci vogliono tutti sempre!
            public CustomException() : base() { } //quello di base
            public CustomException(string message) : base(message) { } //per il messaggio
            public CustomException(string message, Exception inner) : base(message, inner) { }

            //costruttore per la serializzazione
            protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }

    }
}
