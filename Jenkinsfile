pipeline {
  agent any
  stages {
  stage ('Build')
  {
  steps{
		msbuild '1-UnitTest\\UnitTest.sln'
		}
  }
    stage('Test') {
      steps {
        echo 'Hello Mr. Jenkins'
        bat '1-UnitTest\\OpenCover-NUnit.bat'
		publishCoverage adapters: [opencoverAdapter(mergeToOneReport: true, path: 'testing*.xml')], sourceFileResolver: sourceFiles('NEVER_STORE')
      }
    }

  }
}