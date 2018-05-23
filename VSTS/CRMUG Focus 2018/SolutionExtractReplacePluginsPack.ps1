param(
[string]$solutionPackager='C:\CRMSDK\SDK\Bin\SolutionPackager.exe',
[string]$pluginSource='C:\Focus2018\vstsagent\_work\1\s\Plugins\Plugins\bin\Release\Plugins.dll',
[string]$pluginDestination='C:\Focus2018\vstsagent\_work\1\s\CRM\Focus2018Latest\PluginAssemblies\Plugins-ABE79E79-4352-E811-80FD-00155DCFC041\Plugins.dll',
[string]$solutionZip='C:\Focus2018\vstsagent\_work\1\s\CRM\Focus2018Latest.zip',
[string]$solutionPath='C:\Focus2018\vstsagent\_work\1\s\CRM\Focus2018Latest'
)

& "$solutionPackager" /action:Extract /zipfile:"$solutionZip" /folder:"$solutionPath" /allowDelete:Yes /allowWrite:Yes /clobber 

Copy-Item "$pluginSource" -Destination "$pluginDestination"

Remove-Item "$solutionZip"

& "$solutionPackager" /action:Pack /zipfile:"$solutionZip" /folder:"$solutionPath"

Remove-Item -Path "$solutionPath" -Recurse