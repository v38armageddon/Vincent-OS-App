#include "pch.h"
#include "ExplorerToVinDesk.h"

void switchToVinDesk() {
	RegistryKey^ rk = Registry::LocalMachine->OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
	String^ shell = "Shell";
	Object^ o = rk->GetValue(shell);
	if (o == "explorer.exe") {
		
	}
	else {
		throw gcnew System::InvalidOperationException();
	}
}