@pushd %~dp0

@cd ..\packages\SpecRun.Runner.*\tools

SpecRun.exe run Default.srprofile "/baseFolder:%~dp0bin\Debug" /log:specrun.log %2 %3 %4 %5

@popd
