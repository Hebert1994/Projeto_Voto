using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleitor
    {
        private string idpessoa;
        private string ideleicao;
        private string idempresa;

        public string IDpessoa { get => idpessoa; set => idpessoa = value; }
        public string IDeleicao { get => ideleicao; set => ideleicao = value; }
        public string IDempresa { get => idempresa; set => idempresa = value; }
    }
}
