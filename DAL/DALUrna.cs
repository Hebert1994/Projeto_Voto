using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUrna
    {
        private DALConexao conexao;

        public DALUrna (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOUrna modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO urna (idurna, nome, descricao, ip)" +
                    "VALUES (NULL, @nome, @descricao, @ip);" +
                    "SELECT MAX(ID) FROM urna;";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@ip", modelo.IP);

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDurna = idInserido;
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
