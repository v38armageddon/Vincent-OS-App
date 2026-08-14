#include "pch.h"
#include "VinDeskToExplorer.h"

void switchToExplorer() {
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
	std::string newShell = "explorer.exe";
	rk->SetValue("Shell", gcnew System::String(newShell.c_str()));
	rk->Close();
}