# Verifies Length of file path for all files in the SourceDirectory.
# Breaks if file path is 260 characters or more
param(
    $ServiceDirectory
)
Write-Host "ServiceDirectory = $($ServiceDirectory)"
$ServiceDir = If ( $ServiceDirectory -eq '*') { 'sdk' } Else { "sdk/$($ServiceDirectory)" }
Write-Host "ServiceDir = $($ServiceDir)"
Write-Output "Analyzing Path Lengths..."; $LongestPath = ''; $LongestPathLength = 0
Get-ChildItem -Path "./$($ServiceDir)" -Recurse -File | ForEach-Object {
    if ($_.FullName.Length -gt $LongestPathLength) {
        $LongestPathLength = $_.FullName.Length; $LongestPath = $_.FullName 
        if ($LongestPathLength -ge 260) { Write-Output "$($LongestPath) : is 260 or more Characters long. Reduce path length"; exit 1 }
    } }
Write-Output "The Longest path ($($LongestPath)) is $($LongestPathLength) characters long"