# sp-calculadora-juros-api

API de cálculo de juros compostos com apenas um endpoint:
  * /CalculaJuros:
    * Recebe um objeto com o valor inicial e o tempo, faz uma consulta na api <a href="https://github.com/Douuuglas/sp-taxa-juros-api">🔗 sp-taxa-juros-api</a> para retornar o juros e calcula o valor final de acordo com os valores informados.

# Estrutura
 
 Projeto contruído em Asp.Net Core, sem nenhuma camada. Utilizado para testes de integração no projeto <a href="https://github.com/Douuuglas/sp-calculadora-juros-api">🔗 sp-calculadora-juros-api</a>.

# Requisitos para rodar a aplicação
  * .Net 5;
  * Docker 20+;

# Documentação em ambiente Windows

Acessar o terminal do windows e baixar o projeto:
```
git clone https://github.com/Douuuglas/sp-taxa-juros-api.git
```

Entrar na pasta do projeto:
```
cd sp-taxa-juros-api
```

Buildar o projeto:
```
dotnet build
```

Rodar os testes:
```
dotnet test
```

Rodar o projeto:
```
dotnet run --project .\WebApi\WebApi.csproj
```

Buildar o projeto em container:
```
docker build -t taxa-juros-api -f .\WebApi\Dockerfile .
```

Rodar o projeto em container:
```bash
docker run --name taxa-juros-api -dp 8080:80 taxa-juros-api
```


