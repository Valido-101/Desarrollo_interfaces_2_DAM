using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_enero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Media.SoundPlayer reproductor = new System.Media.SoundPlayer(Path.Combine(Application.StartupPath, @"..\..\Resources\Music\[Dubstep] - Varien - Gunmetal Black [Monstercat Release].wav"));
            reproductor.PlayLooping();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_inicio());
        }
    }
}
