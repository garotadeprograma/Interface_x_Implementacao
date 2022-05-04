public interface IPessoa {
    #region Properties

        int Id { get; set; }

        string Nome { get; set; }

        DateTime DataNascimento { get; set; }   
        
    #endregion

    #region Methods
        IEnumerable<IPessoa> ListarPessoas();

        IPessoa BuscarPorNome(string nome);

        IEnumerable<IPessoa> ListarPessoasPorFuncao(FuncaoEnum funcao);

        void AdicionarPessoa(IPessoa pessoa);
    #endregion

}