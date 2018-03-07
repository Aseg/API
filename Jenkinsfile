node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'nuget restore API.sln'
		bat "\"${tool 'MSBuild'}\" API.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.0"

	stage 'Archive'
		archive 'API/bin/Release/**'

}
