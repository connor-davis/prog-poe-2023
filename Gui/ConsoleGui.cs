using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecipes.Gui
{
    /**
     * This class will provide default and required methods to any screen
     * that gets shown in the application.
     */
    abstract class ConsoleGui
    {
        /**
         * This method will display the application name to the console.
         */
        public static void ShowApplicationName()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\r\n  ******** ** ****     **** *******  **       ********       *******   ********   ******  ** *******  ********  ********\r\n **////// /**/**/**   **/**/**////**/**      /**/////       /**////** /**/////   **////**/**/**////**/**/////  **////// \r\n/**       /**/**//** ** /**/**   /**/**      /**            /**   /** /**       **    // /**/**   /**/**      /**       \r\n/*********/**/** //***  /**/******* /**      /*******       /*******  /******* /**       /**/******* /******* /*********\r\n////////**/**/**  //*   /**/**////  /**      /**////        /**///**  /**////  /**       /**/**////  /**////  ////////**\r\n       /**/**/**   /    /**/**      /**      /**            /**  //** /**      //**    **/**/**      /**             /**\r\n ******** /**/**        /**/**      /********/********      /**   //**/******** //****** /**/**      /******** ******** \r\n////////  // //         // //       //////// ////////       //     // ////////   //////  // //       //////// ////////  \r\n");
            Console.WriteLine("");

            /**
             * Then this method will change the consoles foreground back to the
             * default, then ask the user what they would like to do and give them 
             * some options to choose from.
             */
            Console.ForegroundColor = ConsoleColor.White;
        }

        /**
         * This method will display a header to the Console
         */
        public static void DisplayHeader(String text)
        {
            int ConsoleWidth = Console.BufferWidth; // Get the most number of characters currently on one line of the console

            for (int i = 0; i < ConsoleWidth; i++) // Loop through them
            {
                Console.Write("*"); // Write * for every character in one line
            }

            Console.Write("\n");
            Console.WriteLine("* " + text); // Write the header text to the console

            for (int i = 0; i < ConsoleWidth; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        /**
         * This method will return a string from the user
         */
        public string GetStringInput(string prompt, bool canBeEmpty)
        {
            try
            {
                Console.Write(prompt + ": ");

                string value = Console.ReadLine();

                if (canBeEmpty) return value;
                else
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        ClearLine();
                        return GetStringInput(prompt, canBeEmpty);
                    }
                    else return value;
                }
            }
            catch
            {
                ClearLine();
                return GetStringInput(prompt, canBeEmpty);
            }
        }

        /**
         * This method will return an int from the user
         */
        public int GetIntInput(string prompt)
        {
            try
            {
                Console.Write(prompt + ": ");

                return Int32.Parse(Console.ReadLine());
            }
            catch
            {
                ClearLine();
                return GetIntInput(prompt);
            }
        }

        /**
         * This method will return an double from the user
         */
        public double GetDoubleInput(string prompt)
        {
            try
            {
                Console.Write(prompt + ": ");

                return Double.Parse(Console.ReadLine());
            }
            catch
            {
                ClearLine();
                return GetDoubleInput(prompt);
            }
        }

        /**
         * This method will return an float from the user
         */
        public double GetFloatInput(string prompt)
        {
            try
            {
                Console.Write(prompt + ": ");

                return NFloat.Parse(Console.ReadLine());
            }
            catch
            {
                ClearLine();
                return GetFloatInput(prompt);
            }
        }

        /**
         * This method will return an boolean from the user
         */
        public bool GetBooleanInput(string prompt)
        {
            try
            {
                Console.Write(prompt + ": ");

                string value = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(value))
                    return false;

                switch (value)
                {
                    case "true":
                        return true;
                    case "false":
                        return false;
                    case "yes":
                        return true;
                    case "no":
                        return false;
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        return false;
                }
            }
            catch
            {
                ClearLine();
                return GetBooleanInput(prompt);
            }
        }

        /**
         * This method will have to be overrided and implemented by the developer
         * as it is what will be called to display its gui.
         */
        public abstract void Show();

        /**
         * This method will clear the console to blank so that new information can be
         * printed to the console.
         */
        public void Clear()
        {
            Console.Clear();
        }

        /**
         * This method was found with <a href="">this</a> stack overflow resource and
         * it will clear one line in the console.
         */
        public void ClearLine()
        {
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        }
    }
}
