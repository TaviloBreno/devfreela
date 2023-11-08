# DevFreela.Payments

## Visão Geral

O DevFreela.Payments é um microserviço construído em .Net Core, dedicado ao processamento de pagamentos no âmbito do projeto principal DevFreela. Esta API desempenha um papel crucial no ecossistema do DevFreela, facilitando a gestão de transações financeiras relacionadas aos projetos e serviços freelancers.

## Descrição do Projeto

O DevFreela é uma plataforma desenvolvida na plataforma .NET que tem como objetivo promover a conexão entre clientes e desenvolvedores freelancers. Os clientes podem contratar desenvolvedores com base em suas habilidades profissionais, iniciar e gerenciar projetos, além de fornecer feedback sobre o trabalho realizado. Esta API se concentra na parte de pagamento, garantindo que os freelancers sejam adequadamente compensados pelos serviços prestados.

## Funcionalidades

O DevFreela.Payments oferece diversas funcionalidades essenciais, incluindo:

- Registro e gerenciamento de transações de pagamento.
- Integração com provedores de pagamento (por exemplo, PayPal, Stripe, entre outros).
- Notificações de pagamento para os clientes e freelancers.
- Consulta de histórico de transações.
- Processamento de pagamento seguro com suporte a JSON Web Tokens (JWT).

## Tecnologias Utilizadas

Este microserviço faz uso de várias tecnologias e práticas de desenvolvimento, incluindo:

- **Swagger**: Utilizado para documentar e testar a API de forma eficaz.

- **Arquitetura Limpa**: Implementa a Arquitetura Limpa, também conhecida como Onion Architecture, para manter a estrutura organizada e focada no domínio do sistema.

- **Entity Framework Core**: Como ORM (Object-Relational Mapping) principal para interagir com o banco de dados.

- **Dapper**: Utilizado como ORM alternativo, especialmente para consultas de alto desempenho.

- **CQRS (Command-Query Responsibility Segregation)**: Separando as operações de consulta das operações que alteram o estado do sistema.

- **MediatR**: Biblioteca que oferece suporte a Commands e Queries, tornando o código mais legível e separado por responsabilidades.

- **JSON Web Token (JWT)**: Usado para autenticação e segurança na comunicação com outras partes do ecossistema DevFreela.

- **xUnit**: Para a realização de testes unitários e garantir a robustez do código.

## Como Iniciar

Para executar o projeto localmente, siga estas etapas:

1. Clone este repositório.

2. Certifique-se de ter o .NET Core SDK instalado em sua máquina.

3. Configure a conexão com o banco de dados no arquivo `appsettings.json`.

4. Abra o terminal na pasta raiz do projeto e execute o comando:

   ```bash
   dotnet run
