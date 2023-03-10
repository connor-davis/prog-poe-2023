using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    internal class MainScreen : ConsoleGui
    {
        public MainScreen()
        {
            
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Show()
        {
            /**
             * First this method will clear the console, then it will change the
             * color of the consoles foreground, then it will write
             * the title of the application to the console.
             */
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\r\n  ******** ** ****     **** *******  **       ********       *******   ********   ******  ** *******  ********  ********\r\n **////// /**/**/**   **/**/**////**/**      /**/////       /**////** /**/////   **////**/**/**////**/**/////  **////// \r\n/**       /**/**//** ** /**/**   /**/**      /**            /**   /** /**       **    // /**/**   /**/**      /**       \r\n/*********/**/** //***  /**/******* /**      /*******       /*******  /******* /**       /**/******* /******* /*********\r\n////////**/**/**  //*   /**/**////  /**      /**////        /**///**  /**////  /**       /**/**////  /**////  ////////**\r\n       /**/**/**   /    /**/**      /**      /**            /**  //** /**      //**    **/**/**      /**             /**\r\n ******** /**/**        /**/**      /********/********      /**   //**/******** //****** /**/**      /******** ******** \r\n////////  // //         // //       //////// ////////       //     // ////////   //////  // //       //////// ////////  \r\n");
            Console.WriteLine("");

            /**
             * Then this method will change the consoles foreground back to the
             * default, then ask the user what they would like to do and give them 
             * some options to choose from.
             */
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome back Chef. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Create a new recipe.");
            Console.WriteLine("2. Display the stored recipe.");
            Console.WriteLine("3. Change the stored recipe's scale factor.");
            Console.WriteLine("4. Reset the quantities of the stored recipe back to their initial values.");
            Console.WriteLine("5. Clear the stored recipe.");
            Console.WriteLine();
            Console.Write("> ");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                default:
                    {
                        Clear();
                        Show();
                        break;
                    }
            }
        }
    }
}
