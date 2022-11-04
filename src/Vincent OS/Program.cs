using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vincent_OS_Registry;

namespace Vincent_OS
{
    internal static class Program
    {
        [STAThread]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Valider la compatibilité de la plateforme", Justification = "<En attente>")]
        static void Main()
        {
            Registry registry = new Registry();
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            registry.CheckAtStart();
            Application.Run(new Démarrage());
            AppCenter.Start("TOKEN",
                  typeof(Analytics), typeof(Crashes));
            // Hérité de Avant.cs
            My.MyProject.Forms.Custom.RadioButton2.Checked = true;
        }
    }
}
