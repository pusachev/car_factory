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
            if (collection.ContainsKey(menuItem.GetCode()))
            {
                throw new MenuBuilderException(String.Format("Menu Item with code {0} already exists", menuItem.GetCode()));
            }

            collection.Add(menuItem.GetCode(), menuItem);

            return this;
        }

        private IMenuItem GetMenuItem(int code)
        {
            if (!collection.ContainsKey(code))
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

                Console.WriteLine("Enter escape to exit or enter to continue: ");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Bye!");
                    break;
                }

                Console.WriteLine("Please enter correct menu number");
                Console.Write("Your choice: ");

                string data = Console.ReadLine();

                try
                {
                    GetMenuItem(data).Execute();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                catch (InputValidateException e)
                {
                    Console.WriteLine("Please enter valid menu number");
                    Console.ReadLine();
                }
                catch (MenuBuilderException e)
                {
                    Console.WriteLine("Please enter valid menu number");
                    Console.ReadLine();
                }

            }
        }
    }
}
