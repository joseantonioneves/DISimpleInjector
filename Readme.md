# DISimpleInjector

Este repositório demonstra o uso de injeção de dependência em projetos .NET utilizando a biblioteca [SimpleInjector](https://simpleinjector.org/).

## Estrutura do Projeto

- **DISimpleInjector/**  
  Projeto principal, contendo:
  - Camada de Negócio (`BussinessLayer.cs`)
  - Camada de Acesso a Dados (`DataAccessLayer.cs`)
  - Interface de abstração (`ICart.cs`)
  - Configuração do SimpleInjector e execução do programa (`Program.cs`)

- **ClassLibrary1/**  
  Biblioteca de classes auxiliar, que pode conter lógicas ou modelos compartilhados.

## Como funciona

O projeto principal utiliza a interface `ICart` para abstrair operações de carrinho de compras. As implementações concretas são registradas e resolvidas pelo SimpleInjector, promovendo baixo acoplamento entre as camadas.

## Como executar

1. Abra a solução `DISimpleInjector.sln` no Visual Studio.
2. Restaure os pacotes NuGet.
3. Compile a solução.
4. Execute o projeto `DISimpleInjector`.

## Dependências

- [.NET Standard 2.0](https://docs.microsoft.com/dotnet/standard/net-standard)
- [SimpleInjector 4.4.3](https://www.nuget.org/packages/SimpleInjector/4.4.3)

## Licença

Este projeto é apenas para fins educacionais.