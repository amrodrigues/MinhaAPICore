## MinhaAPICORE

Este projeto � uma API web b�sica, criada em **ASP.NET Core**, que demonstra a cria��o e o uso de controladores, roteamento e a��es HTTP. O objetivo principal � servir como um modelo para opera��es CRUD (Create, Read, Update, Delete) em uma API.

### Funcionalidades Principais

* **GET /api/values**: Retorna uma cole��o de strings.

* **GET /api/values/{id}**: Retorna uma string espec�fica, identificada por um `id`.

* **POST /api/values**: Cria um novo recurso `Product` com os dados enviados no corpo da requisi��o.

* **PUT /api/values/{id}**: Atualiza um recurso `Product` existente. A identifica��o � feita pelo `id` na URL.

* **DELETE /api/values/{id}**: Deleta um recurso.

### Estrutura do Projeto

* **`ValuesController`**: O controlador principal que define os endpoints da API. Ele herda de `MainController` para reutilizar funcionalidades comuns, como a formata��o de respostas.

* **`MainController`**: Uma classe abstrata que oferece um m�todo protegido (`CustomResponse`) para padronizar as respostas da API, incluindo mensagens de sucesso e erro.

* **`Product`**: Uma classe de modelo simples que representa a entidade do produto.

* **Atributos de Conven��o da API**: O projeto utiliza `[ApiConventionType]` e `[ApiConventionMethod]` para documentar os c�digos de status HTTP (como `200 OK`, `400 BadRequest`, `201 Created` e `404 Not Found`), garantindo que a API siga as conven��es do ASP.NET Core e seja mais f�cil de ser consumida por outros desenvolvedores.