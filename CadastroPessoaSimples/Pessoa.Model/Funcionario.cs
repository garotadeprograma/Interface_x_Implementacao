namespace Pessoa.Model;

public class Funcionario : IPessoa
{
    private readonly bool _autenticado;
    public Funcionario()
    {
        _autenticado = false;
    }

    public Funcionario(bool autenticado)
    {
        _autenticado = autenticado;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int NumeroMatricula { get; set;}
    public IEnumerable<IPessoa> AdicionarPessoa(IPessoa pessoa)
    {
       var lista = ListarPessoas().ToList();

       if(pessoa != null)
       {
            lista.Add(pessoa);
       }

       return lista.OrderBy(item => item.Nome);
    }
    public IEnumerable<IPessoa> ListarPessoas()
    {
        if(!_autenticado)
        {
            return null;
        }

        return new List<Funcionario>()
        {
            new Funcionario(){Id = 1, Nome = "Amanda Felix", DataNascimento = DateTime.Now, NumeroMatricula = 0038},
            new Funcionario(){Id = 2, Nome = "Juliano Matias", DataNascimento = DateTime.Now, NumeroMatricula = 0039},
            new Funcionario(){Id = 3, Nome = "Mariana Damasceno", DataNascimento = DateTime.Now, NumeroMatricula = 0040}
        };
        
    }
}