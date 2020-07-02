using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEleitor
    {
        private DALConexao conexao;

        public DALEleitor (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOEleitor modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO eleitor (idpessoa, ideleicao, idempresa)" +
                    "VALUES ( @idpessoa, @ideleicao, @idempresa);" +
                    "SELECT MAX(ID) FROM eleitor;";
                cmd.Parameters.AddWithValue("@idpessoa", modelo.IDpessoa);
                cmd.Parameters.AddWithValue("@ideleicao", modelo.IDeleicao);
                cmd.Parameters.AddWithValue("@idempresa", modelo.IDempresa);
                conexao.Conectar();
               
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }






    }
}
