﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrypoint
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Homepage());
            Application.Run(new AdmissionStatus());
            //Application.Run(new StudentApplicationForm());
            //Application.Run(new PaymentForm());
            //Application.Run(new ExamScoreForm());
        }

    }
}
