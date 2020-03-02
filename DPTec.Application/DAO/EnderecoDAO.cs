using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DPTec.Application.DAO
{
    public class EnderecoDAO
    {
        public static List<EnderecoModel> GetEnderecos(EnderecoModel endereco)
        {
            string query = $@"SELECT 
								no_CEP,
								nm_Logradouro,
								nm_Bairro,
								nm_Cidade,
								sg_UF,
								nm_Pais
							FROM Endereco
							WHERE ic_Ativo = 1";
            if (!String.IsNullOrEmpty(endereco.CEP))
            {
                query += $@"AND no_CEP = '{endereco.CEP}'";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<EnderecoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var enderecoModel = new EnderecoModel();
                    enderecoModel.CEP = row["no_CEP"].ToString();
                    enderecoModel.Logradouro = row["nm_Logradouro"].ToString();
                    enderecoModel.Bairro = row["nm_Bairro"].ToString();
                    enderecoModel.Cidade = row["nm_Cidade"].ToString();
                    enderecoModel.UF = row["sg_UF"].ToString();
                    enderecoModel.Pais = row["nm_Pais"].ToString();
                    list.Add(enderecoModel);
                }
            }
            return list;
        }
    }
}