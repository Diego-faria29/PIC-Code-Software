using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class DALVenda
    {
        private DALConection conexao;
        
        public DALVenda(DALConection cx)
        {
            this.conexao = cx;
        }

        public void Vender (MODELOVenda modeloVenda)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "INSERT INTO pedido (id_pedido, data_dia, id_cliente, produto, quantidade, valor_total, forma_pagamento)" +
                    "VALUES (@id_pedido, @dd, @id_cliente, @produto, @quantidade, @valor_total, @forma_pagamento);SELECT LAST_INSERT_ID()";


                cmd.Parameters.AddWithValue("@dd", modeloVenda.Data_dia);
                cmd.Parameters.AddWithValue("@id_cliente", modeloVenda.Id_cliente);
                cmd.Parameters.AddWithValue("@produto", modeloVenda.Produto);
                cmd.Parameters.AddWithValue("@quantidade", modeloVenda.Quantidade);
                cmd.Parameters.AddWithValue("@valor_total", modeloVenda.Valor_total);
                cmd.Parameters.AddWithValue("@forma_pagamento", modeloVenda.Forma_pagamento);
                cmd.Parameters.AddWithValue("@id_pedido", modeloVenda.Id_pedido);
                cmd.Connection = this.conexao.ObjConexao;

                conexao.Conectar();
                int idvendido = Convert.ToInt32(cmd.ExecuteScalar());

                modeloVenda.Id_pedido = idvendido;

                cmd.CommandText = "UPDATE cliente c SET c.valor_pendente = (SELECT SUM(p.valor_total) FROM pedido p WHERE c.id_cliente = p.id_cliente AND p.forma_pagamento = \"Confiança\");";
                cmd.ExecuteNonQuery();
                cmd.CommandText = " UPDATE cliente SET valor_pendente = 0 WHERE valor_pendente = NULL; ";
                cmd.ExecuteNonQuery();
               
                conexao.Desconectar();


            }
            catch(MySqlException error)
            {
                throw error;
            }
            catch(Exception error2)
            {
                throw error2;
            }
        }
       
        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjConexao;

                cmd.CommandText = "DELETE FROM pedido WHERE id_pedido = @id_pedido";
                cmd.Parameters.AddWithValue("@id_pedido", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE cliente c SET c.valor_pendente = (SELECT SUM(p.valor_total) FROM pedido p WHERE c.id_cliente = p.id_cliente AND p.forma_pagamento = \"Confiança\");";
                cmd.ExecuteNonQuery();
                cmd.CommandText = " UPDATE cliente SET valor_pendente = 0 WHERE valor_pendente = NULL; ";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }


        public DataTable localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM pedido WHERE id_cliente LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjConexao);
            adapter.Fill(tabela);

            return tabela;
                
        }
    }
}
