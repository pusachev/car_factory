using System;
namespace AbstractMenu
{
    public class InputValidateException : Exception
    {
        public InputValidateException(string message) : base(message)
        {
        }
    }
}
