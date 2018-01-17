$program = ${ENV:MSBUILD_HOME}.Replace("`"","") + "\bin\msbuild.exe"
& "$program" build.msbuild /v:m