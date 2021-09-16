using System;
using BOSS.az.Static_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS.az.Static_Classes
{
    public static class Controle
    {
        public static int MenuControle(in string[] options)
        {
            int selected = 1;
            while (true)
            {
                Console.Clear();
                Configuration.PrintEntryWord();
                Configuration.PrintMenu(options, selected - 1);
                ConsoleKeyInfo KeyInfoPressed = Console.ReadKey();
                switch (KeyInfoPressed.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected > 1)
                            selected--;
                        else
                            selected = options.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        if (selected < options.Length)
                            selected++;
                        else
                            selected = 1;
                        break;
                    case ConsoleKey.Enter:
                        return selected;
                }
            }
        }

    }
}
