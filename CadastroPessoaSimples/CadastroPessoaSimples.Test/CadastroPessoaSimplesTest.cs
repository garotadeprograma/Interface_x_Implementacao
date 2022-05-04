using Pessoa.Model;
using Xunit;

namespace CadastroPessoaSimples.Test;

public class CadastroPessoaSimplesTest
{
    [Fact]
    public void AcessarClasse_Sucesso()
    {
        var pessoa = new Funcionario();

        bool result =  pessoa.ListarPessoas() != null;

        Assert.True(result, "Not Implemented");

    }
}