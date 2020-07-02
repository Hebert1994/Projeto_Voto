using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOUrna
    {
        private Int32 idurna;
        private string nome;
        private string descricao;
        private string ip;

        public int IDurna { get => idurna; set => idurna = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string IP { get => ip; set => ip = value; }
    }
}
