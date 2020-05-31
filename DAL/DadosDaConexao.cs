using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "remotemysql.com";
        private string port = "3306";
        private string user = "LSUt4AWYHJ";
        private string database = "LSUt4AWYHJ";
        private string password = "cq9MrxXsIt";

        public string StringConection
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id=" + this.user + ";" +
                       "Password=" + this.password + ";" +
                       "database=" + this.database + ";";
                       

            }
        }
    }
}
