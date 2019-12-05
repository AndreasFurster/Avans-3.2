pipeline {
  agent any
  stages {
    stage('Test'){
      steps {
        publishCoverage adapters: [opencoverAdapter(mergeToOneReport: true, path: 'Cobertura.xml')], sourceFileResolver: sourceFiles('NEVER_STORE')
      }
    }

  }
}