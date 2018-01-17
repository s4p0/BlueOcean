pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        powershell(script: '.\\build.ps1', returnStdout: true)
      }
    }
  }
}