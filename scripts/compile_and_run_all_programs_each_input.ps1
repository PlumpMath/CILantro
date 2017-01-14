$TEST_PROGRAMS_DIR = "..\CILSourceCodes\"
$COMPILE_AND_RUN_EACH_INPUT_SCRIPT = "compile_and_run_program_each_input.ps1"

$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path

$testProgramsDir = Join-Path -Path $scriptPath -ChildPath $TEST_PROGRAMS_DIR

$compileAndRunEachInputPath = Join-Path -Path $scriptPath -ChildPath $COMPILE_AND_RUN_EACH_INPUT_SCRIPT

Get-ChildItem $testProgramsDir |
Foreach-Object {
	$programPath = $_.FullName
	$programName = [io.path]::GetFileNameWithoutExtension($programPath)
	
	& $compileAndRunEachInputPath -Program $programName
}