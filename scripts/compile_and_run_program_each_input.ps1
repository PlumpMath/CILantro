param(
	[string]$program
)

$COMPILE_SCRIPT = "compile_program.ps1"
$RUN_EACH_INPUT_SCRIPT = "run_program_each_input.ps1"

$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path

$compilePath = Join-Path -Path $scriptPath -ChildPath $COMPILE_SCRIPT
$runAllInputPath = Join-Path -Path $scriptPath -ChildPath $RUN_EACH_INPUT_SCRIPT

& $compilePath -Program $program
& $runAllInputPath -Program $program