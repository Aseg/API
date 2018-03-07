pipeline {
  agent {
    node {
      label 'Test'
    }
    
  }
  stages {
    stage('Checkout') {
      steps {
        bat "\"${tool 'MSBuild'}\" API.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

      }
    }
  }
}
