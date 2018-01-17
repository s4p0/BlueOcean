$program = ${ENV:NUNIT_HOME}.Replace("`"","") + "\nunit3-console.exe"
& "$program" BuildArtifacts\BlueOceanTester.UT.dll