# Boas-vindas ao repositório do projeto Trybe Games

 
## 1 - Adicionar uma nova pessoa jogadora ao banco de dados
_Implemente o método `AddPlayer()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar uma nova pessoa jogadora e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária o nome da nova pessoa jogadora pelo `Console` e assim criar uma nova instância de `Player` e inserir este no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada nova pessoa jogadora que entrar no banco de dados começando de **1**.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>AddPlayer</code></summary><br />

  Crie os testes para o método `AddPlayer` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddPlayer`. 
  De olho nas dicas👀: 
   1. Será necessário mockar `IConsole` para realizar este teste.
   2. Utilize o `MemberData` de exemplo presente no teste. 
   3. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

## 2 - Adicionar novo Estúdio de Jogos ao banco de dados
_Implemente o método `AddGameStudio()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Estúdio de Jogos e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária o nome do novo Estúdio de Jogos pelo `Console` e assim criar uma nova instância de `GameStudio` e inserir este no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada novo estúdio que entrar no banco de dados, começando de **1**.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>AddGameStudio</code></summary><br />

  Crie os testes para o método `AddGameStudio` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddGameStudio`. 
  De olho nas dicas👀: 
   1. Será necessário mockar `IConsole` para realizar este teste.
   2. Utilize o `MemberData` de exemplo presente no teste.
   3. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

## 3 - Adicionar novo Jogo ao Banco de dados
_Implemente o método `AddGame()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Jogo e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária os seguintes dados de um jogo:
   1. Nome (`Name`).
   2. Data de lançamento (`ReleaseDate`).
   3. Tipo de jogo (`GameType`).
  Lembre-se de que cada um desses atributos possui um tipo específico, e este método deve ser capaz de fazer as conversões necessárias para criar uma nova instância de `Game` corretamente e inseri-la no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada novo jogo que entrar no banco de dados começando de **1**.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>AddGame</code></summary><br />

  Crie os testes para o método `AddGame` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddGame`. 
  De olho nas dicas👀: 
   1. Será necessário mockar `IConsole` para realizar este teste.
   2. Utilize o `MemberData` de exemplo presente no teste.
   3. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

## 4 - Buscar jogos desenvolvidos por um estúdio de jogos
_Implemente o método `GetGamesDevelopedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro um estúdio de jogos e retornar todos os jogos que aquele estúdio desenvolveu</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesFromStudio` para buscar os jogos desenvolvidos pelo estúdio selecionado neste método. Como o método `GetGamesDevelopedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesDevelopedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>GetGamesDevelopedBy</code></summary><br />

  Crie os testes para o método `GetGamesDevelopedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesDevelopedBy`. 
  De olho nas dicas👀: 
   1. Utilize o `MemberData` de exemplo presente no teste.
   2. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

## 5 - Buscar jogos jogados por uma pessoa jogadora
_Implemente o método `GetGamesPlayedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro uma pessoa jogadora e retornar todos os jogos jogados por aquela pessoa jogadora</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesPlayedByPlayer` para buscar os jogos jogados pela pessoa jogadora selecionada neste método. Como o método `GetGamesPlayedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesPlayedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>GetGamesPlayedBy</code></summary><br />

  Crie os testes para o método `GetGamesPlayedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesPlayedBy`. 
  De olho nas dicas👀: 
   1. Utilize o `MemberData` de exemplo presente no teste.
   2. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

## 6 - Buscar jogos comprados por uma pessoa jogadora
_Implemente o método `GetGamesOwnedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro uma pessoa jogadora e retornar todos os jogos que aquela pessoa jogadora possui</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesBoughtByPlayer` para buscar os jogos comprados pela pessoa jogadora selecionada neste método. Como o método `GetGamesOwnedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesOwnedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca.
</details>

<details>
  <summary>Desenvolva o teste para o método <code>GetGamesOwnedBy</code></summary><br />

  Crie os testes para o método `GetGamesOwnedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesOwnedBy`. 
  De olho nas dicas👀: 
   1. Utilize o `MemberData` de exemplo presente no teste.
   2. **Todos os parâmetros para o teste precisam ser utilizados para testar**.
</details>

Agora, com sua ajuda e todo o seu conhecimento em listas, coleções e consultas LINQ em C#, conseguimos finalizar este projeto!
