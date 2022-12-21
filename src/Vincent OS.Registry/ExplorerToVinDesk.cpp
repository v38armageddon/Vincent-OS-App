#include "pch.h"
#include "ExplorerToVinDesk.h"

void switchToVinDesk_MS() {
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
	std::string newShell = "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x64__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe";
	rk->SetValue("Shell", gcnew System::String(newShell.c_str()));
	rk->Close();
}

void switchToVinDesk_ISS() {
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
	std::string newShell = "C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe";
	rk->SetValue("Shell", gcnew System::String(newShell.c_str()));
	rk->Close();
}