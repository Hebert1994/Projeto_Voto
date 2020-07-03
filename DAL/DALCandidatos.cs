using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCandidatos
    {


        private DALConexao conexao;

        public DALCandidatos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOCandidato modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO candidatos (idpessoa, ideleicao, idempresa, numero, slogan, descricao, fotoblog)" +
                    "VALUES (@idpessoa, @ideleicao, @idempresa, @numero, @slogan, @descricao, @fotoblog);" +
                    "SELECT MAX(ID) FROM candidatos;";
                cmd.Parameters.AddWithValue("@idpessoa", modelo.Idpessoa);
                cmd.Parameters.AddWithValue("@ideleicao", modelo.Ideleicao);
                cmd.Parameters.AddWithValue("@idempresa", modelo.Idempresa);
                cmd.Parameters.AddWithValue("@numero", modelo.Numero);
                cmd.Parameters.AddWithValue("@slogan", modelo.Slogan);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@foto", modelo.Foto);

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
