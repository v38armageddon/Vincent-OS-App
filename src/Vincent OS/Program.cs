using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    internal static class Program
    {
        [STAThread]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Valider la compatibilité de la plateforme", Justification = "<En attente>")]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Démarrage());
            AppCenter.Start("0c52f0f9-8169-4918-a2a3-2641062645d0",
                  typeof(Analytics), typeof(Crashes));
            // Hérité de Avant.cs
            My.MyProject.Forms.Custom.RadioButton2.Checked = true;
        }
    }
}
