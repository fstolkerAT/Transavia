@echo off
"C:\Program Files (x86)\NUnit 3.6.0\console\nunit3-console.exe" %1 --skipnontestassemblies
"C:\Users\Frank\Documents\Visual Studio 2017\Projects\Transavia\packages\SpecFlow.2.2.0\tools\specflow.exe" nunitexecutionreport %2 /xmlTestResult:%3
if NOT %errorlevel% == 0 (
echo "Error generating report - %errorlevel%"
GOTO :exit
)
if %errorlevel% ==0 start iexplore "C:\Users\Frank\Documents\Visual Studio 2017\Projects\Transavia\SpecFlow\bin\Debug\TestResult.html"
:exit