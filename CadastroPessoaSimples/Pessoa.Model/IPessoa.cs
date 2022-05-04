namespace Pessoa.Model;

public interface IPessoa {
    #region Properties

        int Id { get; set; }

        string Nome { get; set; }

        DateTime DataNascimento { get; set; }   
        
    #endregion

    #region Methods
        IEnumerable<IPessoa> ListarPessoas();

        IEnumerable<IPessoa> AdicionarPessoa(IPessoa pessoa);
    #endregion

}