using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_interfaces
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Media.SoundPlayer dokkan_music = new System.Media.SoundPlayer(@"8-Bit Dokkan EXTENDED (STR LR SSGSS Gogeta) Advent of Omnipotence.wav");
            dokkan_music.PlayLooping();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
