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

## ADICIONANDO UM CRUD

Este projeto � uma API web criada com **ASP.NET Core** para demonstrar opera��es CRUD (Criar, Ler, Atualizar, Deletar) em um ambiente conectado a um banco de dados, utilizando o **Entity Framework Core**.

### Estrutura do Projeto

O projeto � composto por tr�s classes principais que funcionam em conjunto:

* **`Fornecedor`**: Uma classe de modelo simples que representa a entidade. Ela inclui atributos de valida��o (`[Required]`, `[StringLength]`) para garantir a integridade dos dados antes de salvar no banco.

* **`ApiDbContext`**: A classe de contexto do Entity Framework Core. Ela atua como uma ponte entre o c�digo da sua aplica��o e o banco de dados, permitindo que voc� consulte, adicione, atualize e remova dados da tabela de fornecedores.

* **`FornecedoresController`**: O controlador da API que gerencia todas as requisi��es HTTP para os endpoints de fornecedores. Ele injeta o `ApiDbContext` via construtor e utiliza m�todos ass�ncronos para interagir com o banco de dados de forma eficiente.

### Funcionalidades da API

Os seguintes endpoints est�o dispon�veis para gerenciar os dados dos fornecedores:

* **`GET /api/fornecedores`**: Retorna uma lista com todos os fornecedores no banco de dados.

* **`GET /api/fornecedores/{id}`**: Retorna os dados de um fornecedor espec�fico, buscando por seu `id`.

* **`POST /api/fornecedores`**: Recebe um objeto `Fornecedor` no corpo da requisi��o, salva-o no banco de dados e retorna o fornecedor criado com status `201 Created`.

* **`PUT /api/fornecedores/{id}`**: Atualiza um fornecedor existente no banco de dados. A requisi��o deve incluir o `id` na URL e os dados atualizados no corpo da requisi��o.

* **`DELETE /api/fornecedores/{id}`**: Remove um fornecedor do banco de dados, utilizando o `id` para identifica��o.

### Como Executar o Projeto

1. **Restaurar Pacotes**: Certifique-se de que os pacotes do NuGet est�o instalados. Se o seu projeto n�o reconhecer comandos como `Add-Migration`, execute: