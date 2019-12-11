using System;
namespace AbstractMenu
{
    public interface IMenuItem
    {
        public int GetCode();

        public string GetLabel();

        public void Execute();
    }
}
