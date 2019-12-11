using System;
using System.Collections.Generic;

namespace ConsoleMenu
{
    public class MenuBuilder : IMenuBuilder
    {
        Dictionary<int, IMenuItem> collection = new Dictionary<int, IMenuItem>();

        public MenuBuilder()
        {
        }

        public IMenuBuilder Add(IMenuItem menuItem)
        {
            if (collection.ContainsKey(menuItem.getCode()))
            {
                throw new MenuBuilderException(String.Format("Menu Item with code {0} already exists", menuItem.getCode()));
            }

            collection.Add(menuItem.getCode(), menuItem);

            return this;
        }

        private IMenuItem GetMenuItem(int code)
        {
            if (collection.ContainsKey(code))
            {
                throw new MenuBuilderException(String.Format("Menu Item with code {0} already exists", menuItem.getCode()));
            }

            return collection[code];
        }

        private IMenuItem GetMenuItem(string code)
        {
            int menuCode;

            if (!Int32.TryParse(code, out menuCode))
            {
                throw new InputValidateException("Interger parse failed");
            }

            return GetMenuItem(menuCode);
        }

        public void Show()
        {
            foreach (KeyValuePair<int, IMenuItem> menuItem in collection)
            {
                System.Console.WriteLine("[{0}] {1}", menuItem.Key, menuItem.Value.GetLabel());
            }
        }

        public void Execute()
        {
            while (true)
            {
                System.Console.Clear();
                Show();

                System.Console.WriteLine("Please enter correct menu number");
                string data = System.Console.ReadLine();

                if (System.Console.ReadKey().Key != System.ConsoleKey.Escape)
                {
                    System.Console.WriteLine("Bye!");
                    break;
                }

                

                try
                {
                    GetMenuItem(data).Execute();

                }
                catch (InputValidateException e)
                {
                    System.Console.WriteLine("Please enter valid menu number");
                }
                catch (MenuBuilderException e)
                {
                    System.Console.WriteLine("Please enter valid menu number");
                }

            }
        }
    }
}
