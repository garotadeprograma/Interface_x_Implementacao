using System;
using System.ComponentModel.DataAnnotations;
using Pessoa.Model;
using Xunit;

namespace CadastroPessoaSimples.Test;

public class CadastroPessoaSimplesTest
{
    #region AcessoClasse_Implementação
      /*Neste modelo eu preciso de uma chamada específica para Funcionario e Cliente.
        Além disso, se acontecer alguma alteração na classe Funcionario a chamada vai quebrar
        Add um construtor pra simular um erro na classe implementada*/

        [Fact]
        public void AcessarClasseFuncionario_Sucesso()
        {
            //Implementando direto
            var pessoa = new Funcionario();

            bool result =  pessoa.ListarPessoas() != null;

            Assert.True(result, "Lista Populada");

        }

        [Fact]
        public void AcessarClasseFuncionario_Falha()
        {
            //Implementando direto
            var pessoa = new Funcionario(true);

            bool result =  pessoa.ListarPessoas() == null;

            Assert.False(result, "Lista Vazia");
        }               
    #endregion

    #region AddPessoa
        [Fact]
        public void AddCliente_Falha()
        {
            // Given
            var cliente = new Cliente(){Id = 4, Nome = "Dandara Felix", DataNascimento = DateTime.Now, NumeroPedido = 0038};
            var addPessoa = new OperacoesCadastro(cliente);
            // When
            var resutl = addPessoa.AdicionarPessoa(cliente);
            // Then
            Assert.False(resutl, "Cliente não adicionado");
        }
    
        [Fact]
        public void AddCliente_Sucesso()
        {
            // Given
            var cliente = new Cliente(){Id = 4, Nome = "Tarsila Felix", DataNascimento = DateTime.Now, NumeroPedido = 0038};
            var addPessoa = new OperacoesCadastro(cliente);
            // When
            var resutl = addPessoa.AdicionarPessoa(cliente);
            // Then
            Assert.True(resutl, "Cliente Adicionado");
        }

        [Fact]
        public void AddFuncionario_Sucesso()
        {
            // Given
            var cliente = new Funcionario(true){Id = 4, Nome = "Jane Felix", DataNascimento = DateTime.Now, NumeroMatricula = 0041};
            var addPessoa = new OperacoesCadastro(cliente);
            // When
            var resutl = addPessoa.AdicionarPessoa(cliente);
            // Then
            Assert.False(resutl, "Pessoa Adicionada");
        }

        [Fact]
        public void AddFuncionario_Falha_Construtor()
        {
            // Given
                var cliente = new Funcionario(){Id = 4, Nome = "Simone Felix", DataNascimento = DateTime.Now, NumeroMatricula = 0042};
                var addPessoa = new OperacoesCadastro(cliente);
            // When
                var resutl = addPessoa.AdicionarPessoa(cliente);
            // Then
            Assert.False(resutl, "Lista não populada");
        }

        [Fact]
        public void AddFuncionario_Falha()
        {
            // Given
                var cliente = new Funcionario(false){Id = 4, Nome = "Simone Felix", DataNascimento = DateTime.Now, NumeroMatricula = 0043};
                var addPessoa = new OperacoesCadastro(cliente);
            // When
                var resutl = addPessoa.AdicionarPessoa(cliente);
            // Then
            Assert.False(resutl, "Lista não populada");
        }

        /*Utilizando a classe OperacoesCadastro, não interessa pra classe que está implementando se o obj é Cliente ou funcionário
          O que importa é o tipo IPessoa*/
  #endregion
}