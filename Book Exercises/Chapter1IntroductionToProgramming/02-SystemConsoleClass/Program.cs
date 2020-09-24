using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _02_SystemConsoleClass
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool GetCurrentConsoleFontEx(
            IntPtr consoleOutput,
            bool maximumWindow,
            ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetCurrentConsoleFontEx(
            IntPtr consoleOutput,
            bool maximumWindow,
            CONSOLE_FONT_INFO_EX consoleCurrentFontEx);

        private const int STD_OUTPUT_HANDLE = -11;
        private const int TMPF_TRUETYPE = 4;
        private const int LF_FACESIZE = 32;
        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382");
            Console.WriteLine("Exercise 2" + Environment.NewLine);
            Console.WriteLine("Example source: https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1#examples" + Environment.NewLine);

            ShowUnicodeSupportSample();
            Console.WriteLine();
            ChangeFontFromRasterToLucida();
            Console.WriteLine();
            DefineSimSunFont();
            CombiningCharacters();
        }

        private static void CombiningCharacters()
        {
            char[] chars = new char[] { '\u0061', '\u0308'};

            string combining = new string(chars);
            Console.WriteLine("Before String.Normalize: " + combining);

            combining = combining.Normalize();
            Console.WriteLine("After String.Normalize: " + combining);
        }

        private static void DefineSimSunFont()
        {
            Console.WriteLine("The following example illustrates how you can programmatically define a linked font " + 
                "named SimSun found in a font file named simsun.ttc that displays Simplified Han characters.");
            string valueName = "Lucida Console";
            string newFont = "simsun.ttc,SimSun";
            string[] fonts = null;
            RegistryValueKind kind = 0;
            bool toAdd;

            RegistryKey key = Registry.LocalMachine.OpenSubKey(
                       @"Software\Microsoft\Windows NT\CurrentVersion\FontLink\SystemLink",
                       true);

            if (key == null)
            {
                Console.WriteLine("Font linking is not enabled.");
            }
            else
            {
                // Determine if the font is a base font.
                string[] names = key.GetValueNames();
                if (Array.Exists(names, s => s.Equals(valueName,
                                             StringComparison.OrdinalIgnoreCase)))
                {
                    // Get the value's type.
                    kind = key.GetValueKind(valueName);

                    // Type should be RegistryValueKind.MultiString, but we can't be sure.
                    switch (kind)
                    {
                        case RegistryValueKind.String:
                            fonts = new string[] { (string)key.GetValue(valueName) };
                            break;
                        case RegistryValueKind.MultiString:
                            fonts = (string[])key.GetValue(valueName);
                            break;
                        case RegistryValueKind.None:
                            // Do nothing.
                            fonts = new string[] { };
                            break;
                    }

                    // Determine whether SimSun is a linked font.
                    if (Array.FindIndex(fonts, s => s.IndexOf("SimSun",
                                               StringComparison.OrdinalIgnoreCase) >= 0) >= 0)
                    {
                        Console.WriteLine("Font is already linked.");
                        toAdd = false;
                    }
                    else
                    {
                        // Font is not a linked font.
                        toAdd = true;
                    }
                }
                else
                {
                    // Font is not a base font.
                    toAdd = true;
                    fonts = new string[] { };
                }

                if (toAdd)
                {
                    Array.Resize(ref fonts, fonts.Length + 1);
                    fonts[fonts.GetUpperBound(0)] = newFont;

                    // Change REG_SZ to REG_MULTI_SZ.
                    if (kind == RegistryValueKind.String)
                        key.DeleteValue(valueName, false);

                    key.SetValue(valueName, fonts, RegistryValueKind.MultiString);
                    Console.WriteLine("SimSun added to the list of linked fonts.");
                }
            }

            if (key != null)
            {
                key.Close();
            }

            Console.WriteLine();
        }

        private static unsafe void ChangeFontFromRasterToLucida()
        {
            Console.WriteLine("The following example shows how you can programmatically change the font from a raster font to Lucida Console.");
            string fontName = "Lucida Console";
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);

            if (hnd != INVALID_HANDLE_VALUE)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                bool tt = false;

                // First determine whether there's already a TrueType font.
                if (GetCurrentConsoleFontEx(hnd, false, ref info))
                {
                    tt = (info.FontFamily & TMPF_TRUETYPE) == TMPF_TRUETYPE;

                    if (tt)
                    {
                        Console.WriteLine("The console already is using a TrueType font.");
                        return;
                    }

                    // Set console fonr to Lucida Console.
                    CONSOLE_FONT_INFO_EX newInfo = new CONSOLE_FONT_INFO_EX();
                    newInfo.cbSize = (uint)Marshal.SizeOf(newInfo);
                    newInfo.FontFamily = TMPF_TRUETYPE;
                    IntPtr ptr = new IntPtr(newInfo.FaceName);
                    Marshal.Copy(fontName.ToCharArray(), 0, ptr, fontName.Length);
                    //Get some settings from current font.
                    newInfo.dwFontSize = new COORD(info.dwFontSize.X, info.dwFontSize.Y);
                    newInfo.FontWeight = info.FontWeight;
                    SetCurrentConsoleFontEx(hnd, false, newInfo);
                }
            }
        }

        private static void ShowUnicodeSupportSample()
        {
            Console.WriteLine("Create a Char array for the modern Cyrillic alphabet, from U+0410 to U+044F.");
            int nChars = 0x044F - 0x0410 + 1;
            char[] chars = new char[nChars];
            ushort codePoint = 0x0410;

            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                chars[ctr] = Convert.ToChar(codePoint);
                codePoint++;
            }

            Console.WriteLine("Current code page: {0}\n", Console.OutputEncoding.CodePage);

            foreach (char ch in chars)
            {
                Console.Write("{0} ", ch);

                if (Console.CursorLeft >= 70)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {
            internal short X;
            internal short Y;

            internal COORD(short x, short y)
            {
                X = x;
                Y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal unsafe struct CONSOLE_FONT_INFO_EX
        {
            internal uint cbSize;
            internal uint nFont;
            internal COORD dwFontSize;
            internal int FontFamily;
            internal int FontWeight;
            internal fixed char FaceName[LF_FACESIZE];
        }
    }
}