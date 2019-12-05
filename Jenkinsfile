pipeline {
  agent any
  stages {
    stage('Test') {
      steps {
        echo 'Hello Mr. Jenkins'
        bat '\\1-UnitTest\\OpenCover-NUnit.bat'
      }
    }

  }
}