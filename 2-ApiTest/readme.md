# Testing
Because its just one command in the command line and soap ui delivers its own batch files, we are using the batch file created by soapui.

## steps
` install soapui `

**-f** is the path to put the testfiles  
**-a** is for logging results not just errors.  
**-s** Defines which test suite to test, in our case this is "TricentisTestSuite"  

`your_installation_path\bin\TestRunner.bat -s "TricentisTestSuite" .\tricentis-soapui-project.xml -a -f "TestResult"`  


Deze word ook in pipeline automatisch uitgevoerd.  
