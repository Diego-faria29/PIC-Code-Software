using System;
using System.Collections.Generic;
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
                    "VALUES (NULL, @dd, @id_cliente, @produto, @quantidade, @valor_total, @forma_pagamento);";

                cmd.Parameters.AddWithValue("@dd", modeloVenda.Data_dia);
                cmd.Parameters.AddWithValue("@id_cliente", modeloVenda.Id_cliente);
                cmd.Parameters.AddWithValue("@produto", modeloVenda.Produto);
                cmd.Parameters.AddWithValue("@quantidade", modeloVenda.Quantidade);
                cmd.Parameters.AddWithValue("@valor_total", modeloVenda.Valor_total);
                cmd.Parameters.AddWithValue("@forma_pagamento", modeloVenda.Forma_pagamento);

                cmd.Connection = this.conexao.ObjConexao;
                conexao.Conectar();
                int idvendido = Convert.ToInt32(cmd.ExecuteScalar());

                modeloVenda.Id_pedido = idvendido;

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
    }
}
