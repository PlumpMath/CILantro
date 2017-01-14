param(
	[string]$program
)

$TEST_PROGRAMS_DIR = "..\CILSourceCodes\"
$TEST_PROGRAMS_INPUT_DIR = "in"
$TEST_PROGRAMS_OUTPUT_DIR = "out"
$TEST_PROGRAMS_INPUT_EXT = ".in"
$TEST_PROGRAMS_OUTPUT_EXT = ".out"
$EXE_EXT = ".exe"

$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path

$testProgramsDir = Join-Path -Path $scriptPath -ChildPath $TEST_PROGRAMS_DIR
$programDir = Join-Path -Path $testProgramsDir -ChildPath $program
$programName = $program + $EXE_EXT
$programPath = Join-Path -Path $programDir -ChildPath $programName

$inputDir = Join-Path -Path $programDir -ChildPath $TEST_PROGRAMS_INPUT_DIR
$outputDir = Join-Path -Path $programDir -ChildPath $TEST_PROGRAMS_OUTPUT_DIR

If (Test-Path $inputDir) {
	New-Item -ItemType Directory -Force -Path $outputDir | Out-Null

	Get-ChildItem $inputDir -Filter ("*" + $TEST_PROGRAMS_INPUT_EXT) |
	Foreach-Object {
		$inputFilePath = $_.FullName
		$inputFileName = [io.path]::GetFileNameWithoutExtension($inputFilePath)
		
		$outputFileName = $inputFileName + $TEST_PROGRAMS_OUTPUT_EXT
		$outputFilePath = Join-Path -Path $outputDir -ChildPath $outputFileName
		
		Get-Content $inputFilePath | & $programPath | Out-File $outputFilePath | Out-Null
	}
}
