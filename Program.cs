﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid
{
    static class Program
    {
        /// <summary>
        
        /// </summary>
		/// 1111111111!!!
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_form());
        }
    }
}
