#include "pch.h"
#include "ExplorerToVinDesk.h"
#include <Windows.h>
#include <iostream>

void switchToVinDesk_MS() {
    // Open a handle to the key where the value is stored.
    HKEY hKey;
    LONG lResult = RegOpenKeyEx(HKEY_LOCAL_MACHINE,
        TEXT("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon"),
        0,
        KEY_ALL_ACCESS,
        &hKey);
    if (lResult != ERROR_SUCCESS)
    {
        std::cerr << "Failed to open registry key: " << lResult << "\n";
        std::cerr << "If you see this message, it probably your Windows installation is corrupted. I advice you to reinstall Windows as quickly as possible.";
    }

    // Set the new value for the specified registry key.
    DWORD dwType = REG_SZ; // The type of the value is a string.
    const char* szValue = "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x86__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe"; // The new string value.
    DWORD cbData = static_cast<DWORD>((strlen(szValue) + 1) * sizeof(char)); // The size of the value data, in bytes.
    lResult = RegSetValueEx(hKey,
        TEXT("Shell"), // The name of the value to set.
        0,
        dwType,
        reinterpret_cast<const BYTE*>(szValue),
        cbData);
    if (lResult != ERROR_SUCCESS)
    {
        std::cerr << "Failed to set registry value: " << lResult << "\n";
        RegCloseKey(hKey);
    }

    // Close the handle to the registry key.
    RegCloseKey(hKey);
}

void switchToVinDesk_ISS() {
    // Open a handle to the key where the value is stored.
    HKEY hKey;
    LONG lResult = RegOpenKeyEx(HKEY_LOCAL_MACHINE,
        TEXT("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon"),
        0,
        KEY_ALL_ACCESS,
        &hKey);
    if (lResult != ERROR_SUCCESS)
    {
        std::cerr << "Failed to open registry key: " << lResult << "\n";
        std::cerr << "If you see this message, it probably your Windows installation is corrupted. I advice you to reinstall Windows as quickly as possible.";
    }

    // Set the new value for the specified registry key.
    DWORD dwType = REG_SZ; // The type of the value is a string.
    const char* szValue = "C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe"; // The new string value.
    DWORD cbData = static_cast<DWORD>((strlen(szValue) + 1) * sizeof(char)); // The size of the value data, in bytes.
    lResult = RegSetValueEx(hKey,
        TEXT("Shell"), // The name of the value to set.
        0,
        dwType,
        reinterpret_cast<const BYTE*>(szValue),
        cbData);
    if (lResult != ERROR_SUCCESS)
    {
        std::cerr << "Failed to set registry value: " << lResult << "\n";
        RegCloseKey(hKey);
    }

    // Close the handle to the registry key.
    RegCloseKey(hKey);
}