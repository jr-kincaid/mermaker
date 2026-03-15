param(
    [string]
    $exportPath = "Extensions.txt"
)
# Execute list-extensions script pipe output to file at $exportPath
& "$PSScriptRoot/Get-ExtensionList.ps1" > $exportPath