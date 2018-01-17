$msbuild = "C:\Program Files (x86)\Msbuild\12.0\Bin\msbuild.exe"
& $msbuild /t:Clean BlueOceanTester.sln
& $msbuild BlueOceanTester.sln /v:m