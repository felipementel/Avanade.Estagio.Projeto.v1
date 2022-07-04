# Avanade.Estagio.Projeto.v1

## Pre-requisito:
> Ter a SDK do .NET 6 instalada
> 
> Ter acesso a um banco de dados MySQL

<hr>

## Passos para colocar o projeto para funcionar:

1. Clonar o repositório para a sua máquina, utilizando o git bash
```git
git clone https://github.com/felipementel/Avanade.Estagio.Projeto.v1.git
```


2. Executar o powershell como administrador e instalar o CLI do Entity Framework Core

```cli
dotnet tool install --global dotnet-ef
```

3. Ajustar a connection string para o seu ambiente local. A modificação deve ser realizada no arquivo:

> Repositorio/CervejaContext.cs 

4. Executar o migrations para criar a estrutura do banco de dados (table, columns, ...). Acesse novamente o PowerShell como administrador, navegue ate a pasta src/Avanade.Estagiario.API e execute o seguinte comando:

```ps
dotnet ef database update
```

5. Execute a aplicação apertando F5 no seu visual studio.
Pode ser que na primeira execução, o Visual Studio precise que vc aceite algumas licenças certificados https falsos, para execução local. Clique em Yes todas as vezes que for necessário nesse momento.


<hr>

### Abaixo um exemplo de um request do tipo POST para criação de uma cerveja no sistema

```json
{
  "marca": "Brahma",
  "nome": "Purol Malte",
  "gelada": true,
  "compra": "2022-07-01T13:51:42.584Z",
  "teorAlcoolico": 4.7
}
```
