namespace Pessoa.Model;

public class OperacoesCadastro
{
    private readonly IPessoa _pessoa;

    public OperacoesCadastro(IPessoa pessoa)
    {
        _pessoa = pessoa;
    }
    public bool AdicionarPessoa(IPessoa pessoa)
    {
        var list = _pessoa.AdicionarPessoa(pessoa);
    
        return list.Select(item => item.Nome == pessoa.Nome) != null;
    }

    public bool ListarPessoas()
    {
       return _pessoa.ListarPessoas() != null;
    }
}