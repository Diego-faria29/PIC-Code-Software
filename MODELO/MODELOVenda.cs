using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*reflete uma tabela do bd*/
namespace MODELO
{
    public class MODELOVenda
    {
        /*Atributos*/
        private int id_pedido;
        private DateTime data_dia;
        private int id_cliente;
        private string produto;
        private int quantidade;
        private float valor_total;
        private string forma_pagamento;

        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public DateTime Data_dia { get => data_dia; set => data_dia = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public float Valor_total { get => valor_total; set => valor_total = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
    }
}
