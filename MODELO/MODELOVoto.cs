using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOVoto
    {
        private string ideleicao;
        private string idurna;
        private string idpessoa;
        private string numerovoto;

        public string Ideleicao { get => ideleicao; set => ideleicao = value; }
        public string Idurna { get => idurna; set => idurna = value; }
        public string Idpessoa { get => idpessoa; set => idpessoa = value; }
        public string Numerovoto { get => numerovoto; set => numerovoto = value; }
    }
}
