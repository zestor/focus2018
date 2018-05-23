param(
[string]$ExportSolutionOutputPath='C:\Focus2018\GitHub\CRMUG Focus 2018\CRM',
[string]$ExportSolutionEXE='C:\Focus2018\Visual Studio Projects\ExportCRMSolution\ExportCRMSolution\bin\Debug\ExportCRMSolution.exe'
)
Write-Host "Update DEV CRM solution version number 1.0.0.(X)"
$solzip = &$ExportSolutionEXE fusion2018dev.crm.powerobjects.net Focus2018
Write-Host "Exported Unmanaged DEV CRM Solution $solzip...."
Write-Host "Copy $solzip into CRM folder both as version and Latest"
Copy-Item "$solzip" -Destination "$ExportSolutionOutputPath\$solzip"
Copy-Item "$solzip" -Destination "$ExportSolutionOutputPath\Focus2018Latest.zip"
Write-Host "Delete $solzip file"
Remove-Item "$solzip"
Write-Host "GIT Add Files"
git add -v "$ExportSolutionOutputPath\$solzip"
git add -v "$ExportSolutionOutputPath\Focus2018Latest.zip"
Write-Host "GIT Commit Files"
git commit -q -m "Developer PowerShell Check In"
Write-Host "GIT Push Files to GitHub"
git push -q --set-upstream GitHub master
$status = (Invoke-WebRequest -Method Get -Uri http://localhost:8080/job/Focus%202018%20GIT/build?token=asdf).StatusDescription
Write-Host "Jenkins Build Request:" -NoNewline
Write-Host $status -ForegroundColor Yellow


