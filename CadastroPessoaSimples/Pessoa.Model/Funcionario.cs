namespace Pessoa.Model;

public class Funcionario : IPessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int NumeroMatricula { get; set;}
    public void AdicionarPessoa(IPessoa pessoa)
    {
        throw new NotImplementedException();
    }

    public IPessoa BuscarPorNome(string nome)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IPessoa> ListarPessoas()
    {
        return new List<Funcionario>()
        {
            new Funcionario(){Id = 1, Nome = "Amanda Felix", DataNascimento = DateTime.Now, NumeroMatricula = 0038},
            new Funcionario(){Id = 2, Nome = "Juliano Matias", DataNascimento = DateTime.Now, NumeroMatricula = 0039},
            new Funcionario(){Id = 3, Nome = "Mariana Damasceno", DataNascimento = DateTime.Now, NumeroMatricula = 0040}
        };
    }

    public IEnumerable<IPessoa> ListarPessoasPorFuncao(FuncaoEnum funcao)
    {
        throw new NotImplementedException();
    }
}