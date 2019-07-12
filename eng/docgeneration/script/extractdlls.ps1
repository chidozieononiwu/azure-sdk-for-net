# Rename packages from .nupkg to .zip and expand the archive
# Copy the items to the dll directory

param (
    $PkgDirPath,
    $DllDirPath
)

Set-Location $PkgDirPath
$PkgList = Get-ChildItem -Path $PkgDirPath

foreach ($PkgName in $PkgList) {
    if (!$PkgName.Name.EndsWith('snupkg')) {
        Rename-Item -Path $PkgName.Name -NewName "$($PkgName.BaseName).zip"
        Expand-Archive -Path "$($PkgName.BaseName).zip"
        Remove-Item -Path "$($PkgName.BaseName).zip" -Force

        $DllPath = Join-Path -Path $PkgDirPath -ChildPath "$($PkgName.BaseName)/lib/netstandard2.0/*"

        if (Test-Path -Path $DllPath) {
            Copy-Item $DllPath -Destination $DllDirPath
        }
        else {
            Write-Host "$($DllPath) does not exist"
        }
    }
    else {
        Remove-Item -Path $PkgName.FullName -Force
    }
}
