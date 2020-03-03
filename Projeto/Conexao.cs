using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public static class Conexao
    {
        // string de conexao
        public static string conexao = @"Data Source=SJC0557976W10-1;
                                        Initial Catalog=Projeto_Integrador;
                                        User Id=sa;
                                        Password=senac@sjc";

        //criar a conexao
        public static SqlConnection conn;


        // Método para abrir a conexao
        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            //abrir a conexao
            conn.Open();
        }

        //metado para fechar conexao
        public static void Desconectar()
        {
            //fechar conexao
            conn.Close();
        }
    }
}