#include "pch.h"
#include "Registry.h"
#include "ExplorerToVinDesk.h"
#include "VinDeskToExplorer.h"

// C'est la partie importante où faut bien exporter pour le DLL
//extern "C" {
//	DLL_EXPORT void ToVinDesk() {
//		std::filesystem::path path1("C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x86__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe");
//		std::filesystem::path path2("C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe");
//		if (std::filesystem::exists(path1)) {
//			switchToVinDesk_MS();
//		}
//		else if (std::filesystem::exists(path2)) {
//			switchToVinDesk_ISS();
//		}
//		else {
//			throw gcnew EntryPointNotFoundException;
//		}
//	}
//
//	DLL_EXPORT void ToExplorer() {
//		switchToExplorer();
//	}
//}

void Vincent_OS_Registry::Registry::ToVinDesk()
{
	std::filesystem::path path1("C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x86__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe");
	std::filesystem::path path2("C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe");
	if (std::filesystem::exists(path1)) {
		switchToVinDesk_MS();
	}
	else if (std::filesystem::exists(path2)) {
		switchToVinDesk_ISS();
	}
	else {
		throw gcnew EntryPointNotFoundException;
	}
	
}

void Vincent_OS_Registry::Registry::ToExplorer()
{
	switchToExplorer();
}
