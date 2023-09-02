using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincent_OS_App.ViewModels
{
    public class LoginPageViewModels
    {
        public string Username { get; set; }

        
        public void GetUsername()
        {
            Username = "Superutilisateur";
        }
    }
}
