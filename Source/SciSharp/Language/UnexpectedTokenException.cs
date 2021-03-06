using System;


namespace SciSharp.Language
{
    [Serializable]
    public class UnexpectedTokenException : ParsingException
    {
        public UnexpectedTokenException(string token)
            : base(string.Format("Unexpected token found in input stream: {0}", token)) {}
    }
}
