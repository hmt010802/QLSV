﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quản_lý_sinh_viên_PKA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
