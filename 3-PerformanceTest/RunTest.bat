set currentpath=%~dp0
set reportpath=%currentpath%neoload-report

"C:\Program Files\NeoLoad 7.0\bin\NeoLoadCmd.exe" ^
  -project "%currentpath%NeoLoad.nlp" ^
  -launch "scenario1" ^
  -testResultName "$Date{hh:mm - dd MMM yyyy} (build ${BUILD_NUMBER})" ^
  -report "%reportpath%/report.html,%reportpath%/report.xml" ^
  -SLAJUnitResults "%reportpath%/junit-sla-results.xml" ^
  -noGUI

exit %ERRORLEVEL%