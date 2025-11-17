# MyService

🧠 Uppgift: Smart Multi-Stage CI/CD för en .NET API


🎯 Mål
Bygg en fungerande CI/CD-pipeline för ett enkelt .NET Web API-projekt med hjälp av GitHub Actions, environments, secrets och variabler.
Din workflow ska automatiskt bygga, testa och deploya din applikation — med tydlig logik och säkra regler mellan stegen.


🧱 Krav
1. Repository-setup
Skapa ett nytt .NET Web API-projekt (t.ex. MyService.Api)
Lägg till ett NUnit testprojekt (t.ex. MyService.Tests)
Ladda upp båda projekten till ditt GitHub-repo
Testprojektet ska innehålla minst ett test för en metod i ditt API
(t.ex. ett test som verifierar att en metod returnerar rätt värde)

2. GitHub Environments
Skapa två environments under Settings → Environments
dev
prod (kräver manuell granskning/approval innan deploy)

I prod, lägg till en secret:

PROD_API_KEY = prod-xyz-123

Lägg till en repository-variabel:
SERVICE_NAME = my-dotnet-api

3. Workflow
Skapa en workflow-fil:
 📄 .github/workflows/05-smart-multistage.yml


Din workflow ska:
Köras automatiskt vid varje push

Innehålla fyra jobs:

build: återställer och bygger projektet

test: kör NUnit-tester

deploy-dev: deployar till dev om testerna passerar

deploy-prod: deployar till prod om testerna passerar och branchen är main

Använda jobberoenden (needs:) och villkor (if:)

Använda repo-variabeln ${{ vars.SERVICE_NAME }}

Visa secrets maskerade i loggarna
