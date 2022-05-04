namespace Pessoa.Model;

public class Cliente : IPessoa
{
   
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int NumeroPedido { get; set;}

    public IEnumerable<IPessoa> AdicionarPessoa(IPessoa pessoa)
    {
        var lista = ListarPessoas().ToList();

       if(pessoa != null)
       
     {       lista.Add(pessoa);
       }

       return lista.OrderBy(item => item.Nome);
    }

    public IEnumerable<IPessoa> ListarPessoas()
    {
        
        return new List<Cliente>()
        {
            new Cliente(){Id = 1, Nome = "Dandara Felix", DataNascimento = DateTime.Now, NumeroPedido = 0038},
            new Cliente(){Id = 2, Nome = "Frida Matias", DataNascimento = DateTime.Now, NumeroPedido = 0039},
            new Cliente(){Id = 3, Nome = "Joana Damasceno", DataNascimento = DateTime.Now, NumeroPedido = 0040}
        };
    }

}