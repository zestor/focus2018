param(
[string]$solutionPackager='C:\CRMSDK\SDK\Bin\SolutionPackager.exe',
[string]$mappingFile='C:\Focus2018\SolutionPackagerMappingFile\mapping.xml',
[string]$tfCommand='C:\Focus2018\vstsagent\externals\vstshost\tf.exe',
[string]$ExportSolutionOutputPath='C:\Focus2018\VSTS\CRMUG Focus 2018\CRM',
[string]$ExportSolutionEXE='C:\Focus2018\Visual Studio Projects\ExportCRMSolution\ExportCRMSolution\bin\Debug\ExportCRMSolution.exe'
)

Write-Host "Exporting Solution..."

$solzip = &$ExportSolutionEXE fusion2018dev.crm.powerobjects.net Focus2018

Write-Host "Exported Unmanaged Solution $solzip...."
  
Copy-Item "$solzip" -Destination "$ExportSolutionOutputPath"
Copy-Item "$solzip" "Focus2018Latest.zip"
Copy-Item "Focus2018Latest.zip" -Destination "$ExportSolutionOutputPath"
  
Remove-Item "$solzip"
Remove-Item "Focus2018Latest.zip"

$solzip2 = $ExportSolutionOutputPath + '\' + $solzip

& "$tfCommand" add /noprompt "$solzip2"
& "$tfCommand" workspaces /collection:https://zestor.visualstudio.com
& "$tfCommand" checkin "$ExportSolutionOutputPath" /recursive /noprompt /comment:"PowerShell DEV Export"  