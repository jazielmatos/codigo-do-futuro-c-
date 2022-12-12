using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int qtd { get; set; }

        public static int qtdID = 0;

        public Produto(int id,string nome,int qtd)
        {
            qtdID ++;
            this.Id = id + qtdID;
            this.Nome = nome;
            this.qtd = qtd;

        }
        
    }
}
