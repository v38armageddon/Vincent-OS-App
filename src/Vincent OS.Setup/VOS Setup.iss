; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Vincent OS App"
#define MyAppVersion "10"
#define MyAppPublisher "v38armageddon"
#define MyAppURL "https://www.vincent-os.cf/"
#define MyAppExeName "Vincent OS.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{343384D8-FBA4-4984-BC9B-277960A47326}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS.Setup\Output
OutputBaseFilename=Vincent OS App Setup
SetupIconFile=E:\v38armageddon\Pictures\Projets\Vincent OS\logo.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "armenian"; MessagesFile: "compiler:Languages\Armenian.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "bulgarian"; MessagesFile: "compiler:Languages\Bulgarian.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "corsican"; MessagesFile: "compiler:Languages\Corsican.isl"
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"
Name: "danish"; MessagesFile: "compiler:Languages\Danish.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "finnish"; MessagesFile: "compiler:Languages\Finnish.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "hebrew"; MessagesFile: "compiler:Languages\Hebrew.isl"
Name: "icelandic"; MessagesFile: "compiler:Languages\Icelandic.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "norwegian"; MessagesFile: "compiler:Languages\Norwegian.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "slovak"; MessagesFile: "compiler:Languages\Slovak.isl"
Name: "slovenian"; MessagesFile: "compiler:Languages\Slovenian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; It's a fucking hell to add all new dlls in hand
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\cs\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\de\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\es\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\fr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\it\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\ja\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\ko\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\pt-BR\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\ru\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\runtimes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\tr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\zh-Hans\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\zh-Hant\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\AxInterop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\DesktopBridge.Helpers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Ijwhost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Interop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.AppCenter.Analytics.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.AppCenter.Crashes.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.AppCenter.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Extensions.ObjectPool.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Web.WebView2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Web.WebView2.WinForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Web.WebView2.Wpf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Win32.SystemEvents.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Microsoft.Windows.SDK.NET.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\SQLitePCLRaw.batteries_v2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\SQLitePCLRaw.core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\SQLitePCLRaw.provider.e_sqlite3.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ComponentModel.Composition.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ComponentModel.Composition.Registration.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Configuration.ConfigurationManager.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Data.Odbc.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Data.OleDb.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Data.SqlClient.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Diagnostics.PerformanceCounter.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.DirectoryServices.AccountManagement.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.DirectoryServices.Protocols.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.IO.Ports.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Management.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Private.ServiceModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Reflection.Context.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Runtime.Caching.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Security.Cryptography.Pkcs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Security.Cryptography.Xml.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.Duplex.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.Http.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.NetTcp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.Security.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceModel.Syndication.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.ServiceProcess.ServiceController.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Speech.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\System.Web.Services.Description.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.Registry.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.Registry.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\Vincent OS.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\v38armageddon\Documents\GitHub\v38armageddon\Vincent-OS\src\Vincent OS\bin\Release\net6.0-windows10.0.22621.0\WinRT.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

