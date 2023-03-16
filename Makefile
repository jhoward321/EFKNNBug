SHELL := /bin/bash

.PHONY: run apply-migrations remove-db

run: 
	docker-compose up -d db
	dotnet ef database update
	dotnet run

apply-migrations:
	dotnet ef database update

remove-db:
	docker-compose up -d db
	docker-compose down --volumes
