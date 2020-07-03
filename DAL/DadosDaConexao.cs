using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "localhost";
        private string port = "3306";
        private string user = "root";
        private string pass = "";
        private string database = "projeto_voto";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id= " + this.user + ";" +
                       "Password=" + this.pass + ";" +
                       "database= " + this.database + ";";
            }
        }

    }
}
