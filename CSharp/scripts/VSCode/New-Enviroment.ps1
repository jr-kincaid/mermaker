# Backup your current extension list.
$fullDate = & "$PSScriptRoot\..\Get-FullDate.ps1"
& "$PSScriptRoot\New-BackupExtensionList.ps1" -exportPath ($fullDate + "backupExtensionList")

# This will remove all installed extensions for VS Code. (Caution)
& "$PSScriptRoot\Get-ExtensionList.ps1" | ForEach-Object { code --uninstall-extension $_ --force }

# Extensions.txt is a list of VS Code Extensions.
# We pipe those extensions into ForEach then install them.
Get-Content "$PSScriptRoot\Extensions" | ForEach-Object { code --install-extension $_ }