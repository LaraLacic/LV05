﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string GetHeader(int width)
        {
            return new string('*', width);
        }

        public string GetFooter(int width)
        {
            return new string('-', width);
        }
    }
}
