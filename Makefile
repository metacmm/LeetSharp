default: build
pre-build:
	dotnet restore
build:
	dotnet build
test:
	dotnet test
