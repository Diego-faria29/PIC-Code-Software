using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* CLASSE REFLETE A UMA TABELA DO BANCO DE DADOS*/
namespace MODELO
{
    public class MODELOCliente
    {
        private int id_cliente;
        private string nome;
        private string email;
        private string cpf;
        private string telefone;
        private string endereco;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
