using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace onelovebar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LottoPage : Page
    {
        public LottoPage()
        {
            this.InitializeComponent();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------Welcome to my lotto number generator------------------\n", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------Numbers---------------------------PowerBall---------", Console.ForegroundColor);
            Boolean menu = true;
            do
            {
                Random r = new Random();
                int num = r.Next(1, 40);


                for (int i = 0; i < 6; i++)
                {
                    int n = r.Next(1, 41);
                    num = n >= num ? n + 1 : n;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write($"{num}\t", Console.ForegroundColor);
                }

                Random x = new Random();
                int nums = x.Next(1, 10);


                for (int y = 0; y < 1; y++)
                {
                    int n = r.Next(1, 9);
                    nums = n >= nums ? n + 1 : n;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"|\t{nums}\n", Console.ForegroundColor);
                }

                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nWould you like to add another line Y/N: ", Console.ForegroundColor);
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                { menu = false; }
                else if (check == "Y")
                {
                    Console.Write("\n");
                    menu = true;
                }
                else
                    break;



            } while (menu);
            Console.ReadLine();
        }
    }
}
