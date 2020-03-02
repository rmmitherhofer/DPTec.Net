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
    public class EmpresaDAO
    {
        public static List<EmpresaModel> GetEmpresas(int codigoEmpresa)
        {
            string query = $@"SELECT 
	                            cd_Empresa,
	                            nm_Fantasia,
	                            nm_Razao_Social,
	                            no_CNPJ,
	                            no_Insc_Estadual,
	                            nm_Segmento,
	                            ts_Abertura,
	                            ts_Fechamento,
	                            cd_Status,
	                            nm_Site,
	                            cd_Categoria,
	                            no_CEP,
	                            no_Endereco,
	                            nm_Complemento,
	                            no_Telefone_SAC,
	                            no_Telefone_Ouvidoria,
	                            nm_Pais_Origem
                            FROM Empresa
                            WHERE cd_Status = 1";
            if (codigoEmpresa != 0)
            {
                query += $@"AND cd_Empresa = {codigoEmpresa}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<EmpresaModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var empresaModel = new EmpresaModel();
                    empresaModel.CodigoEmpresa = int.Parse(row["cd_Empresa"].ToString());
                    empresaModel.NomeFantasia = row["nm_Fantasia"].ToString();
                    empresaModel.NomeRazaoSocial = row["nm_Razao_Social"].ToString();
                    empresaModel.NumCNPJ = long.Parse(row["no_CNPJ"].ToString());
                    empresaModel.NumInscricaoEstadual = long.Parse(row["no_Insc_Estadual"].ToString());
                    empresaModel.NomeSegmento = row["nm_Segmento"].ToString();
                    empresaModel.DataAbertura = DateTime.Parse(row["ts_Abertura"].ToString());
                    //empresaModel.DataFechamento = DateTime.Parse(row["ts_Fechamento"].ToString());
                    empresaModel.NomeSite = row["nm_Site"].ToString();
                    //empresaModel.categoria = row["cd_Categoria"].ToString();
                    empresaModel.NumCEP = row["no_CEP"].ToString();
                    empresaModel.NumLogradouro = row["no_Endereco"].ToString();
                    empresaModel.NomeComplemento = row["nm_Complemento"].ToString();
                    empresaModel.NumTelefoneEmpresa = long.Parse(row["no_Telefone_SAC"].ToString());
                    empresaModel.NumTelefoneOuvidoria = long.Parse(row["no_Telefone_Ouvidoria"].ToString());
                    empresaModel.NomePais = row["nm_Pais_Origem"].ToString();
                    list.Add(empresaModel);
                }
            }
            return list;
        }
    }
}