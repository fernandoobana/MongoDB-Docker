# Console App Dotnet Core conectando ao MongoDB (NoSQL)

Uma aplicação console que faz conexão ao banco de dados MongoDB criado no docker.

Com o docker instalado em sua máquina, execute em um terminal (exemplo: Power Shell) o comando abaixo:


```diff
docker run --name nomeContainer -e MONGO_INITDB_ROOT_USERNAME=nomeUsuarioBanco -e MONGO_INITDB_ROOT_PASSWORD=senhaUsuarioBanco -p 27017:27017 -d mongo:3.6.18
```


onde:
- <i>nomeContainer</i>: um nome qualquer para seu container; se não for especificado, o docker irá gerar um nome aleatório
- <i>nomeUsuarioBanco</i>: nome do usuário que irá ter permissão para acessar o banco
- <i>senhaUsuarioBanco</i>: senha do usuário que irá ter permissão para acessar o banco

<h4>Observações: </h4>

- Como é um simples teste, não foi aplicado boas práticas como SOLID, camadas, etc... está tudo em um único projeto.
- Não foi criado um Dockerfile ou docker compose por se tratar de um console. 
Para testes talvez seja mais práticos apenas criar o banco no docker e executar a aplicação, fazendo as alterações pertinentes.
- Não é obrigatório criar usuário e senha para acesso ao MongoDB; caso não queira, apenas remova as variáveis no comando.
- <b>Altere na aplicação (arquivo Service.cs) o usuário e senha que você especificou</b>; Se não for utilizar usuário e senha, altere
a conexão para "mongodb://localhost:{porta_que_voce_especificou_no_comando}"
- Foi exposta a porta 27017 para que seja possível acessar o banco externamente. Se você já tiver a instância do mongo instalada
na sua máquina, altere para outra porta.
