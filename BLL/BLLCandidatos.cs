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
    public class BLLCandidatos
    {
        private DALCandidatos DALobj;

        public BLLCandidatos(DALConexao cx)
        {
            DALobj = new DALCandidatos(cx);
        }

        public void Incluir(MODELOCandidato modelo)
        {
            try
            {
                if (modelo.Idpessoa == "")
                {
                    throw new ArgumentNullException("Campos IDpessoa não pode ser vazio.");
                }
                if (modelo.Ideleicao == "")
                {
                    throw new ArgumentNullException("Campos IDeleicao não pode ser vazio.");
                }
                if (modelo.Idempresa == "")
                {
                    throw new ArgumentNullException("Campos IDempresa não pode ser vazio.");
                }
                if (modelo.Numero == "")
                {
                    throw new ArgumentNullException("Numero", "Nao pode ser vazio.");
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
