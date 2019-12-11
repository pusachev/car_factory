using System;
namespace ConsoleMenu
{
    public class InputValidateException : Exception
    {
        public InputValidateException(string message) : base(message)
        {
        }
    }
}
