
dev:
	trap 'kill %1' SIGINT
	sam local start-api

build:
	dotnet build

test: build
	dotnet test

publish:
	dotnet publish -c Release

infra:
	cd infrastructure && ./deploy.sh
