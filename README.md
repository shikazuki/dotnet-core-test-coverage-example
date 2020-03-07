# dotnet-core-test-coverage-example
Output Test Coverage Demo.

## Use
`$ docker-compose run --rm dev bash `

### Output Test Coverage
`$ dotnet test --collect:"XPlat Code Coverage"`

### Convert Test Coverage To HTML
`$ dotnet ~/.nuget/packages/reportgenerator/4.5.0/tools/netcoreapp3.0/ReportGenerator.dll -reports:./Example.Tests/TestResults/{hash}/coverage.cobertura.xml -targetdir:./Example.Tests/TestResults/out/`
