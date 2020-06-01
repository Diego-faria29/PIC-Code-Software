using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/*Data Acess La*/
namespace DAL
{
    public class DALConection
    {
        private string strConexao;
        private MySqlConnection conexao;

        public DALConection (string dadosConexao)
        {
            conexao = new MySqlConnection();
            strConexao = dadosConexao;
            conexao.ConnectionString = dadosConexao;
        }
        public MySqlConnection ObjConexao
        {
            get { return conexao; }
            set { conexao = value; }
        }
        public MySqlConnection Conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                this.conexao.Open();
            }
                
            return conexao;
        }
        public void Desconectar()
        {
            this.conexao.Close();
        }
    }
}
