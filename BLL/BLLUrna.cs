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
    public class BLLUrna
    {
        private DALUrna DALobj;

        public BLLUrna (DALConexao cx)
        {
            DALobj = new DALUrna(cx);
        }

        public void Incluir(MODELOUrna modelo)
        {
            try
            {
                if (modelo.Nome == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.Descricao == "")
                {
                    throw new ArgumentNullException("IP", "Nao pode ser vazio.");
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
