# sp-calculadora-juros-api

API de cálculo de juros compostos com apenas um endpoint:
  * /CalculaJuros:
    * Recebe um objeto com o valor inicial e o tempo, faz uma consulta na api <a href="https://github.com/Douuuglas/sp-taxa-juros-api">🔗 sp-taxa-juros-api</a> para retornar o juros e calcula o valor final de acordo com os valores informados.

# Estrutura
 
 Projeto contruído em Asp.Net Core e com uma implementação simples de DDD, TDD, container, injeção de dependência e teste de integração.

# Requisitos para rodar a aplicação
  * .Net 5;
  * Docker 20+;

# Documentação em ambiente Windows

Acessar o terminal do windows e baixar o projeto:
```
git clone https://github.com/Douuuglas/sp-calculadora-juros-api.git
```

Entrar na pasta do projeto:
```
cd sp-calculadora-juros-api
```

Buildar o projeto:
```
dotnet build
```

Rodar os testes:
 * O ideal era utilzar o docker-compose que montasse o ambiente automaticamente, mas fica como melhoria! :D
 * Primeiro colocar para rodar a API sp-taxa-juros-api em container, utilizado o passo a passo descrito <a href="https://github.com/Douuuglas/sp-taxa-juros-api">🔗 aqui</a>;
 * Após, executar o comando abaixo.
```
dotnet test
```

Rodar o projeto:
```
dotnet run --project .\WebApi\WebApi.csproj
```

Buildar o projeto em container:
```
docker build -t calculadora-juros-api -f .\WebApi\Dockerfile .
```

Rodar o projeto em container:
```
docker run --name calculadora-juros-api -dp 8081:80 calculadora-juros-api
```


