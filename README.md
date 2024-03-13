# Gestão de Laboratórios
Este é um projeto destinado à criação de uma aplicação web de Gestão de Laboratórios, desenvolvida como parte de um Teste de Performance (TP). Esta aplicação permitirá gerenciar informações sobre computadores em um laboratório, proporcionando funcionalidades de cadastro, leitura, atualização e exclusão (CRUD).

## Requisitos do Projeto
* Criar uma aplicação Web no Visual Studio utilizando o template correspondente com o nome GestaoDeLaboratorios.
* Criar uma pasta Models e dentro dela uma classe Computadores com os seguintes atributos:
1. Id
2. Marca
3. Processador
4. Placa Mãe
5. Memória
6. HD
7. NumeroPratrimonio
8. Data de compra

* Criar uma View de Computadores utilizando o Scaffold, e adicionar as páginas Razor utilizando o Entity Framework.
* Selecionar a classe Computador como modelo e criar uma classe DbContext com o nome InfnetDbContext.
* Executar os comandos Add-Migration e Update-Database no Package Manager Console.
* Fazer com que o sistema apresente inicialmente todos os computadores cadastrados.
* Testar a aplicação realizando um CRUD de um computador.

## Execução do Projeto
Clone este repositório para o seu ambiente local.
Abra o projeto no Visual Studio.
Certifique-se de ter o ASP.NET Core instalado em sua máquina.
Execute os comandos Add-Migration e Update-Database no Package Manager Console para criar o banco de dados com base no modelo.
Execute a aplicação no Visual Studio.
Explore as funcionalidades de CRUD para gerenciar os computadores do laboratório.

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para sugerir melhorias, reportar bugs ou enviar pull requests para este projeto.

## Autor
Este projeto foi desenvolvido como parte de um Teste de Performance 3 (TP3) por Leonardo Muniz.

Nota: Lembre-se de salvar seu trabalho em PDF conforme as instruções fornecidas, nomeando o arquivo conforme a regra "nome_sobrenome_DR4_TP3.PDF".
