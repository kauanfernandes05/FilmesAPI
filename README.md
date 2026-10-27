
# 🎬 FilmesAPI

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

## 📖 Sobre o Projeto

A **FilmesAPI** é uma API REST desenvolvida em **C# com ASP.NET Core (.NET 8)**, com o objetivo de gerenciar informações de filmes por meio de operações de cadastro, consulta, atualização e exclusão.

O projeto foi desenvolvido como parte dos meus estudos em desenvolvimento Back-End, buscando aplicar conceitos de APIs REST, integração com banco de dados e boas práticas de desenvolvimento de software.

A aplicação utiliza **Entity Framework Core** para persistência de dados, **AutoMapper** para mapeamento entre entidades e DTOs e **Swagger** para documentação dos endpoints.

## 🎯 Objetivo do Projeto

O principal objetivo da FilmesAPI é aprofundar meus conhecimentos no desenvolvimento Back-End utilizando o ecossistema .NET.

Durante o desenvolvimento, foram trabalhados os seguintes conceitos:

- Desenvolvimento de APIs REST com ASP.NET Core.
- Aplicação dos métodos HTTP GET, POST, PUT, PATCH e DELETE.
- Integração com banco de dados MySQL.
- Utilização do Entity Framework Core.
- Mapeamento de objetos com AutoMapper.
- Implementação de DTOs.
- Documentação XML integrada ao Swagger.
- Testes de requisições HTTP com Postman.
- Versionamento de código utilizando Git e GitHub.

## 🛠️ Tecnologias e Ferramentas

| Tecnologia | Utilização |
|---|---|
| C# | Linguagem principal |
| .NET 8 | Plataforma de desenvolvimento |
| ASP.NET Core | Desenvolvimento da API REST |
| Entity Framework Core | Persistência de dados |
| MySQL | Banco de dados relacional |
| AutoMapper | Mapeamento de objetos e DTOs |
| Swagger / OpenAPI | Documentação dos endpoints |
| Visual Studio 2022 | Desenvolvimento e depuração |
| MySQL Workbench | Gerenciamento do banco de dados |
| Postman | Testes das requisições HTTP |
| Git e GitHub | Versionamento de código |

## ⚙️ Funcionalidades

A FilmesAPI permite realizar operações CRUD para gerenciamento de filmes.

- **Cadastrar filmes:** adiciona novos registros ao banco de dados.
- **Listar filmes:** consulta os filmes cadastrados com paginação.
- **Buscar por ID:** recupera um filme específico.
- **Atualizar filme:** modifica completamente os dados de um filme.
- **Atualização parcial:** altera campos específicos utilizando JSON Patch.
- **Excluir filme:** remove um filme do banco de dados.

## 🌐 Endpoints da API

| Método HTTP | Endpoint | Descrição |
|---|---|---|
| POST | `/Filme` | Cadastra um novo filme |
| GET | `/Filme` | Lista os filmes cadastrados |
| GET | `/Filme/{id}` | Recupera um filme pelo ID |
| PUT | `/Filme/{id}` | Atualiza um filme |
| PATCH | `/Filme/{id}` | Atualiza parcialmente um filme |
| DELETE | `/Filme/{id}` | Exclui um filme |

### Códigos de Resposta HTTP

- `200 OK` — Requisição realizada com sucesso.
- `201 Created` — Filme cadastrado com sucesso.
- `204 No Content` — Operação concluída sem conteúdo de resposta.
- `400 Bad Request` — Requisição inválida.
- `404 Not Found` — Filme não encontrado.

## 🏗️ Estrutura do Projeto

O projeto foi organizado utilizando separação de responsabilidades.

- **Controllers:** gerenciamento das requisições HTTP.
- **Models:** representação das entidades.
- **DTOs:** transferência de dados entre a API e o cliente.
- **Data:** configuração e acesso ao banco de dados.
- **Profiles:** configurações de mapeamento do AutoMapper.
- **Program.cs:** configuração dos serviços e inicialização da aplicação.

## 📚 Documentação com Swagger

A API possui documentação dos endpoints utilizando **Swagger/OpenAPI** e comentários XML do C#.

A documentação apresenta:

- Descrição das funcionalidades.
- Parâmetros recebidos pelos métodos.
- Tipos de retorno.
- Códigos de resposta HTTP.
- Informações sobre as operações disponíveis.

O Swagger também permite executar requisições para testar os endpoints durante o desenvolvimento.

## 🧪 Testes com Postman

O **Postman** foi utilizado para testar as requisições HTTP da aplicação.

Com ele, é possível verificar o funcionamento das operações CRUD e analisar as respostas retornadas pela API.

## 🚀 Aprendizados

O desenvolvimento da FilmesAPI proporcionou experiência prática com:

- Estruturação de aplicações ASP.NET Core.
- Desenvolvimento de Controllers e endpoints.
- Integração com banco de dados relacional.
- Utilização de Entity Framework Core.
- Mapeamento de dados com AutoMapper.
- Documentação de APIs.
- Testes e depuração de requisições.
- Versionamento e organização de projetos no GitHub.

Este projeto representa mais uma etapa da minha evolução como desenvolvedor de software, consolidando conhecimentos fundamentais para o desenvolvimento Back-End.

## 👨‍💻 Desenvolvedor

**Kauan Fernandes**

Estudante de Engenharia de Software | Estagiário de Desenvolvimento

🔗 [LinkedIn](https://www.linkedin.com/in/kauan-fernandes05/)

---

⭐ Projeto desenvolvido para fins educacionais e aprimoramento dos conhecimentos em C#, ASP.NET Core e desenvolvimento Back-End.
