using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVoto
    {

        private DALConexao conexao;

        public DALVoto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOVoto modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO voto (ideleicao, idurna, idpessoa, numerovoto)" +
                    "VALUES ( @ideleicao, @idurna, @idpessoa, @numerovoto);" +
                    "SELECT MAX(ID) FROM voto;";
                cmd.Parameters.AddWithValue("@ideleicao", modelo.Ideleicao);
                cmd.Parameters.AddWithValue("@idurna", modelo.Idurna);
                cmd.Parameters.AddWithValue("@idpessoa", modelo.Idpessoa);
                cmd.Parameters.AddWithValue("@numerovoto", modelo.Numerovoto);

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
