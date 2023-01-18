#include "pch.h"
#include "Regedit.h"

void Vincent_OS_Registry::Regedit::GetInfo()
{
	// Get the Key and value for HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
	String^ shell = "Shell";
	Object^ o = rk->GetValue(shell);
	return;
	throw gcnew System::NotImplementedException();
}

void Vincent_OS_Registry::Regedit::AtStart()
{
	GetInfo();
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
	String^ shell = "Shell";
	Object^ o = rk->GetValue(shell);
	if (o == "explorer.exe") {

	}
	else if (o == "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x86__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe") {

	}
	else if (o == "C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe") {

	}
	else {
		// crash the app because it significaly installed in portable mode or worst case, it's pirated.
		throw gcnew System::PlatformNotSupportedException();
	}
	throw gcnew System::NotImplementedException();
}
