using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Vincent_OS.Units.Tests
{
    [TestClass]
    public class TestRegistry
    {
        [TestMethod]
        public void CheckRegistry()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
            string shell = "Shell";
            Object o = rk.GetValue(shell);
            if (o != null)
            {
                Console.WriteLine(o);
            }
            else
            {
                Console.WriteLine("Checking value has failed. Please check at: regedit");
                throw new NullReferenceException();
            }
        }
    }
}