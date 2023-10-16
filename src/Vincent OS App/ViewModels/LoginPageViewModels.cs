using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Vincent_OS_App.ViewModels
{
    public class LoginPageViewModels
    {
        public string Username { get; set; }
        public string Userpicture { get; set; }

        
        public void GetUsername()
        {
            Username = Environment.UserName;
        }

        public void GetUserpicture()
        {
            // Request WMI for the user profiles
            string query = "SELECT * FROM Win32_UserProfile WHERE Special = False AND Loaded = True";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject profile in results)
            {
                // Get the local path of the profile
                string profileImagePath = profile["LocalPath"].ToString();

                // Build the full path of the profile image
                string profileImageFullPath = System.IO.Path.Combine(profileImagePath, "AppData\\Roaming\\Microsoft\\Windows\\AccountPictures\\user.png");

                // Verify if the profile image exists
                if (System.IO.File.Exists(profileImageFullPath))
                {
                    Userpicture = profileImageFullPath;
                }
                else
                {
                    Debug.WriteLine("[ERROR] No profile picture detected. Using Vincent OS App default.");
                }
            }
        }
    }
}
