@ECHO OFF
ECHO Demo Automation Executed Started.

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe "C:\Users\saiffham\source\repos\AutomationWeek2\AutomationWeek2\bin\Debug\AutomationWeek2.dll" /Logger:"trx;LogFileName=C:\Users\saiffham\source\repos\AutomationWeek2\TestSummaryReport\Test1.trx"

cd C:\Users\saiffham\source\repos\AutomationWeek2\AutomationWeek2\bin\Debug
TrxerConsole.exe C:\Users\saiffham\source\repos\AutomationWeek2\TestSummaryReport

PAUSE	