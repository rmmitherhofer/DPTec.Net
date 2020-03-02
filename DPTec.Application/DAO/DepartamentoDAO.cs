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
    public class DepartamentoDAO
    {
        public static List<DepartamentoModel> GetDepartamentos(int codigoDepatamento)
        {
            string query = $@"SELECT 
								cd_Departamento,
								ds_Departamento,
								cd_CCusto,
								cd_Matricula
							FROM Departamento
							WHERE ic_Ativo = 1";
            if (codigoDepatamento != 0)
            {
                query += $@"AND cd_Departamento = {codigoDepatamento}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<DepartamentoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var departamentoModel = new DepartamentoModel();
                    departamentoModel.CodigoDepartamento = int.Parse(row["cd_Departamento"].ToString());
                    departamentoModel.DescricaoDepartamento = row["ds_Departamento"].ToString();
                    departamentoModel.CentroCusto = row["cd_CCusto"].ToString();
                    if (!String.IsNullOrEmpty(row["cd_Matricula"].ToString()))
                    {
                        departamentoModel.MatriculaImediato = int.Parse(row["cd_Matricula"].ToString());
                    }
                    list.Add(departamentoModel);
                }
            }
            return list;
        }
    }
}