using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVoto
    {
        private DALVoto DALobj;

        public BLLVoto (DALConexao cx)
        {
            DALobj = new DALVoto(cx);
        }

        public void Incluir(MODELOVoto modelo)
        {
            try
            {
                if (modelo.Ideleicao == "")
                {
                    throw new ArgumentNullException("Campos IDeleicao não pode ser vazio.");
                }
                if (modelo.Idurna == "")
                {
                    throw new ArgumentNullException("Campos IDurna não pode ser vazio.");
                }
                if (modelo.Idpessoa == "")
                {
                    throw new ArgumentNullException("Campos IDpessoa não pode ser vazio.");
                }
                if (modelo.Numerovoto == "")
                {
                    throw new ArgumentNullException("Campos Numero do Candidato não pode ser vazio.");
                }

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

