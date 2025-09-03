## MinhaAPICORE

Este projeto é uma API web básica, criada em **ASP.NET Core**, que demonstra a criação e o uso de controladores, roteamento e ações HTTP. O objetivo principal é servir como um modelo para operações CRUD (Create, Read, Update, Delete) em uma API.

### Funcionalidades Principais

* **GET /api/values**: Retorna uma coleção de strings.

* **GET /api/values/{id}**: Retorna uma string específica, identificada por um `id`.

* **POST /api/values**: Cria um novo recurso `Product` com os dados enviados no corpo da requisição.

* **PUT /api/values/{id}**: Atualiza um recurso `Product` existente. A identificação é feita pelo `id` na URL.

* **DELETE /api/values/{id}**: Deleta um recurso.

### Estrutura do Projeto

* **`ValuesController`**: O controlador principal que define os endpoints da API. Ele herda de `MainController` para reutilizar funcionalidades comuns, como a formatação de respostas.

* **`MainController`**: Uma classe abstrata que oferece um método protegido (`CustomResponse`) para padronizar as respostas da API, incluindo mensagens de sucesso e erro.

* **`Product`**: Uma classe de modelo simples que representa a entidade do produto.

* **Atributos de Convenção da API**: O projeto utiliza `[ApiConventionType]` e `[ApiConventionMethod]` para documentar os códigos de status HTTP (como `200 OK`, `400 BadRequest`, `201 Created` e `404 Not Found`), garantindo que a API siga as convenções do ASP.NET Core e seja mais fácil de ser consumida por outros desenvolvedores.