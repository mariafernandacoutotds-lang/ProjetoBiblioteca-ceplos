using System.Collections.Generic;
using SisBib.Modelos;
namespace SisBib.Data
{
    // A DaL APENAS armazena e recuper dados.Não faz validações nem imprime texto.

    public class LivroRepository
    {
        private static List<Livro>_tabelaLivros= new List<Livro>();

        private static int proximold = 1;

        public void Adicionar(Livro livro)
        {
            livro.id=proximold++;
            _tabelaLivros.Add(livro);
        }
        public List<Livro>ObterTodos()
        
        {
            return_tabelaLivros;
        
}
}
}
