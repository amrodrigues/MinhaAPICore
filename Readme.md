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

## ADICIONANDO UM CRUD

Este projeto é uma API web criada com **ASP.NET Core** para demonstrar operações CRUD (Criar, Ler, Atualizar, Deletar) em um ambiente conectado a um banco de dados, utilizando o **Entity Framework Core**.

### Estrutura do Projeto

O projeto é composto por três classes principais que funcionam em conjunto:

* **`Fornecedor`**: Uma classe de modelo simples que representa a entidade. Ela inclui atributos de validação (`[Required]`, `[StringLength]`) para garantir a integridade dos dados antes de salvar no banco.

* **`ApiDbContext`**: A classe de contexto do Entity Framework Core. Ela atua como uma ponte entre o código da sua aplicação e o banco de dados, permitindo que você consulte, adicione, atualize e remova dados da tabela de fornecedores.

* **`FornecedoresController`**: O controlador da API que gerencia todas as requisições HTTP para os endpoints de fornecedores. Ele injeta o `ApiDbContext` via construtor e utiliza métodos assíncronos para interagir com o banco de dados de forma eficiente.

### Funcionalidades da API

Os seguintes endpoints estão disponíveis para gerenciar os dados dos fornecedores:

* **`GET /api/fornecedores`**: Retorna uma lista com todos os fornecedores no banco de dados.

* **`GET /api/fornecedores/{id}`**: Retorna os dados de um fornecedor específico, buscando por seu `id`.

* **`POST /api/fornecedores`**: Recebe um objeto `Fornecedor` no corpo da requisição, salva-o no banco de dados e retorna o fornecedor criado com status `201 Created`.

* **`PUT /api/fornecedores/{id}`**: Atualiza um fornecedor existente no banco de dados. A requisição deve incluir o `id` na URL e os dados atualizados no corpo da requisição.

* **`DELETE /api/fornecedores/{id}`**: Remove um fornecedor do banco de dados, utilizando o `id` para identificação.

### Como Executar o Projeto

1. **Restaurar Pacotes**: Certifique-se de que os pacotes do NuGet estão instalados. Se o seu projeto não reconhecer comandos como `Add-Migration`, execute: