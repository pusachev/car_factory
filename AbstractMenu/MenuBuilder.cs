using System;
using System.Collections.Generic;

namespace AbstractMenu
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
                throw new MenuBuilderException(String.Format("Menu Item with code {0} already exists", code));
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
                Console.WriteLine("[{0}] {1}", menuItem.Key, menuItem.Value.GetLabel());
            }
        }

        public void Execute()
        {
            while (true)
            {
                Console.Clear();
                Show();

                Console.WriteLine("Please enter correct menu number");
                string data = System.Console.ReadLine();

                if (Console.ReadKey().Key != System.ConsoleKey.Escape)
                {
                    Console.WriteLine("Bye!");
                    break;
                }

                try
                {
                    GetMenuItem(data).Execute();

                }
                catch (InputValidateException e)
                {
                    Console.WriteLine("Please enter valid menu number");
                }
                catch (MenuBuilderException e)
                {
                    Console.WriteLine("Please enter valid menu number");
                }

            }
        }
    }
}
