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
    public class BLLEleitor
    {
        private DALEleitor DALobj;

        public BLLEleitor (DALConexao cx)
        {
            DALobj = new DALEleitor(cx);
        }

        public void Incluir(MODELOEleitor modelo)
        {
            try
            {
                if (modelo.IDpessoa == "")
                {
                    throw new ArgumentNullException("Campos IDpessoa não pode ser vazio.");
                }
                if (modelo.IDeleicao == "")
                {
                    throw new ArgumentNullException("Campos IDeleicao não pode ser vazio.");
                }
                if (modelo.IDempresa == "")
                {
                    throw new ArgumentNullException("Campos IDempresa não pode ser vazio.");
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
