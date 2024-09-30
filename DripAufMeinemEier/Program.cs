using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace Main
{
    class Program
    {

        // Constants 
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERD = 0x80000;
        private const int LWA_ALPHA = 0x2;

        // Windows API
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        // Opacity method
        private static void SetConsoleOpacity(byte opacity)
        {
            IntPtr hWnd = GetConsoleWindow();
            int windowLong = GetWindowLong(hWnd, GWL_EXSTYLE);
            SetWindowLong(hWnd, GWL_EXSTYLE, windowLong | WS_EX_LAYERD);
            SetLayeredWindowAttributes(hWnd, 0, opacity, LWA_ALPHA);
        }

        public static string textLogo =
                        @"" + Environment.NewLine +
            @"" + Environment.NewLine +
            @"                         /$$$$$$  /$$       /$$       /$$       /$$ /$$                                            " + Environment.NewLine +
            @"                        /$$__  $$| $$      |__/      | $$      | $$|__/                                            " + Environment.NewLine +
            @"                       | $$  \__/| $$   /$$ /$$  /$$$$$$$  /$$$$$$$ /$$ /$$$$$$$   /$$$$$$                         " + Environment.NewLine +
            @"                       |  $$$$$$ | $$  /$$/| $$ /$$__  $$ /$$__  $$| $$| $$__  $$ /$$__  $$                        " + Environment.NewLine +
            @"                        \____  $$| $$$$$$/ | $$| $$  | $$| $$  | $$| $$| $$  \ $$| $$  \ $$                        " + Environment.NewLine +
            @"                        /$$  \ $$| $$_  $$ | $$| $$  | $$| $$  | $$| $$| $$  | $$| $$  | $$                        " + Environment.NewLine +
            @"                       |  $$$$$$/| $$ \  $$| $$|  $$$$$$$|  $$$$$$$| $$| $$  | $$|  $$$$$$$                        " + Environment.NewLine +
            @"                        \______/ |__/  \__/|__/ \_______/ \_______/|__/|__/  |__/ \____  $$                        " + Environment.NewLine +
            @"                                                                                   /$$  \ $$                       " + Environment.NewLine +
            @"                                                                                  |  $$$$$$/                       " + Environment.NewLine +
            @"                                                                                   \______/                        " + Environment.NewLine +
            @"                                             Made By Cl4vr/2Behindert                                              " + Environment.NewLine;


        static async Task Main(string[] args)
        {
            try
            {
                Console.ResetColor();
                Console.Clear();

                SetConsoleOpacity(245);

                while (true)
                {
                    Console.Clear();
                    Console.Title =("Know all c++ data types im not a skid I Swear!!!11!!!1!! ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(textLogo);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                       ╔ is Drip.dev riding 2Behinderts Dick?════╗");
                    Console.WriteLine("                                       ║ ----                                    ║");
                    Console.WriteLine("                                       ║ [1] Yes                                 ║");
                    Console.WriteLine("                                       ║ [2] No                                  ║");
                    Console.WriteLine("                                       ║ ----                                    ║");
                    Console.WriteLine("                                       ║ [8] Changelogs                          ║");
                    Console.WriteLine("                                       ║ [9] Credits                             ║");
                    Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                    Console.WriteLine("                                           Enter Your Option And Press Enter      ");
                    Console.WriteLine("                                                      ->                          ");
                    Console.SetCursorPosition(58, 26);

                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        Console.Write(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔═════════════════════════════════════════╗");
                        Console.WriteLine("                                       ║                Ja Ist Er                ║");
                        Console.WriteLine("                                       ║                Yes He is                ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.ReadLine();
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.Write(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔═════════════════════════════════════════╗");
                        Console.WriteLine("                                       ║              Falsche Antwort            ║");
                        Console.WriteLine("                                       ║                Wrong Answer             ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.ReadLine();
                    }

                    else if (input == "8")
                    {
                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                                            Note: This will Change Overtime       ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                                       ╔ ChangeLogs ═════════════════════════════╗");
                        Console.WriteLine("                                       ║  V1.0 = added Everything Basic Ahh menu ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Options ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 26);
                        Console.ReadLine();
                    }

                    else if (input == "9")
                    {
                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Credits ════════════════════════════════╗");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║       Cl4vr - Main Developer            ║");
                        Console.WriteLine("                                       ║      https://github.com/2Behindert      ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Options ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 26);
                        Console.ReadLine();
                    }


                    else
                    {
                        Console.WriteLine("Invalid option");
                        Console.ReadLine();
                        break;
                    }



                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }



        }
    }
 }