using System;
namespace ConsoleMenu
{
    public interface IMenuItem
    {
        public int getCode();

        public string GetLabel();

        public void Execute();
    }
}
