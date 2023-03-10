using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
