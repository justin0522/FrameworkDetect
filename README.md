# FrameworkDetect
get the .net framework version  
- .NET Framework 1-4
  In the Registry Editor, open the following subkey: "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP" The installed versions are listed under the NDP subkey. The version number is stored in the Version entry. For the .NET Framework 4 the Version entry is under the Client or Full subkey (under NDP), or under both subkeys.
- .NET Framework 4.5 and later  
  In the Registry Editor, open the following subkey: "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" The value of the Release DWORD indicates which version of the .NET Framework is installed.  
  
For more information, refer to [How to: Determine which .NET Framework versions are installed](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed#net_a)