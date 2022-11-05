#include "pch.h"
#include "Registry.h"

void GetInfo() {
	// Get the Key and value for HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
	String^ shell = "Shell";
	Object^ o = rk->GetValue(shell);
	
}

void AtStart() {
	GetInfo();
	
}