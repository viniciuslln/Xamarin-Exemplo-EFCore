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
O pacote se mostrou linker safe e o app não apresentou crashes mesmo com d8/r8 e linker (Sdk Assemblies only) ativados;


Comparativo de tamanho final no apk em modo Release com linker (Sdk Assemblies only) ativado:
|            | Tamanho |
|------------|---------|
| Sem EFCore | 12MB    |
| Com EFcore | 19Mb    |


# Futuras implementações e testes

- [ ] Acesso ao DbContext via injeção de de dependência
- [ ] Modelo com relacioinamentos
- [ ] Migrations
- [ ] Configurações de Modelos complexos
