pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                echo 'Hello World'
            }
        }
         stage('Deploy') {
            steps {
                archiveArtifacts artifacts: 'docker-compose.yml', fingerprint: true
            }
        }
    }
    post { 
        always { 
            echo 'Anas!'
        }
    }
}
