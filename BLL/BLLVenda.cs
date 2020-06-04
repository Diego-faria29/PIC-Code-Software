using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLVenda
    {
        private DALVenda DALvenda;
        public BLLVenda(DALConection cx)
        {
            this.DALvenda = new DALVenda(cx);
        }

        public void Vender (MODELOVenda modeloVenda)
        {
            /*gerencia de dados*/
            try
            {   
                if (modeloVenda.Valor_total == 0)
                {
                    throw new ArgumentNullException("Valor total", "Valor total não pode ser 0");
                }
                if (modeloVenda.Produto == "")
                {
                    throw new ArgumentNullException("Produto", "Produto não foi preenchido");
                }
                if (modeloVenda.Valor_total == 0)
                {
                    throw new ArgumentNullException("Valor total", "Valor total não pode ser 0");
                }
                if (modeloVenda.Forma_pagamento == "")
                {
                    throw new ArgumentNullException("Forma de pagamento", "Alguma forma de pagamento deve ser selecionada");
                }
                DALvenda.Vender(modeloVenda);
            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }

        }

        public DataTable localizar(string texto)
        {
            return DALvenda.localizar(texto);
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {

                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALvenda.Excluir(codigo);
        }

    }
}
