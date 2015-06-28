using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsParse
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
            Parse.ParseClient.Initialize("YtsLV3dQgkqJNsgalKmeDQG2jl00f211BdYFzHr9", "FJ4Q2wJnWtKrKwBfrikzGEWCbG1iE9Vx91BEkDog");
            Application.Run(new Form1());
        }
    }
}
