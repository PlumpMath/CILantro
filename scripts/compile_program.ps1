param(
	[string]$program
)

$TEST_PROGRAMS_DIR = "..\CILSourceCodes\"
$CIL_EXT = ".il"

$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path

$testProgramsDir = Join-Path -Path $scriptPath -ChildPath $TEST_PROGRAMS_DIR
$programDir = Join-Path -Path $testProgramsDir -ChildPath $program
$programName = $program + $CIL_EXT
$programPath = Join-Path -Path $programDir -ChildPath $programName

ilasm $programPath | Out-Null