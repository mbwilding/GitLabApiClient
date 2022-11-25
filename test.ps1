$dockerOSType = docker info --format "{{.OSType}}"
if ($dockerOSType -ieq 'linux') {
  & dotnet test --verbosity normal --settings coverletArgs.runsettings --no-build --no-restore
} else {
  & dotnet test --filter Category!=LinuxIntegration --verbosity normal --settings coverletArgs.runsettings --no-build --no-restore
}

$exitWithError = $LastExitCode -ne 0

if ($exitWithError) {
  exit 1
}
