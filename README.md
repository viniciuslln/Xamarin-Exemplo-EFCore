# Xamarin-Exemplo-EFCore
Projeto de teste com EF core em app Xamarin Forms

Foi modificado o app do templade Shell padrão do Visual Studio 2019 alterando o modelo de dados apresentado para persistir em um banco de dados Sqlite com Entity Framework Core.

- Guia utilizado: https://docs.microsoft.com/pt-br/ef/core/get-started/xamarin
- Observações:
  - Foi modificado o serviço depersistência de dados do templete.
  - Todas as transações foram feitas instanciando um novo objeto do DBContext seguindo o guia
  - Testa em Xamarin.Forms 5 preview em Emulador Android 10 e iPad com iOS 12
  
# Conclusões

Nova versão do EFCore funcionou como uma solução “Out of the box”, não foi necessário nenhuma configuração especial para funcionar, entretando foi observado maior demora na inicialização do app;

# Futuras implementações e testes

[] Acesso ao DbContext via injeção de de dependência
[] Modelo com relacioinamentos
[] Migrations
[] Coonfigurações de Modelos complexos
