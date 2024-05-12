; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PTZ Controller"
#define MyAppVersion "1.0.2.0"
#define MyAppPublisher "Rodrigo Bueno"
#define MyAppURL "https://rodrigobueno.dev"
#define MyAppExeName "ViscaControllerPtz.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{6D877FEC-0CBD-455C-94FC-82EF19BA5BAD}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\SETUP
OutputBaseFilename=SetupPtzController
SetupIconFile=C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\ViscaControllerPtz.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\ViscaControllerPtz.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\ViscaControllerPtz.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\websocket-sharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Projetos\ViscaControllerPtz\ViscaControllerPtz\bin\Release\websocket-sharp.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
