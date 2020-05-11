using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
            Application.Run(new Form1());
            //Hotel hotel = new Hotel(3, "Europa", new float[3] { 453.30f, 321.43f, 43.65f });
           // Rezervari r = new Rezervari(1);
           // r = r + hotel;
            //MessageBox.Show(r.ListaHoteluri.ElementAt(0).ToString());
        }
    }
}
