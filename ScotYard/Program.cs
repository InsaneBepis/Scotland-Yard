﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ScotYard.Logique;
using ScotAI;
using System.Drawing;

namespace ScotYard
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenetreJeu());     
        }
    }
}
