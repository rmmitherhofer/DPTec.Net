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
    public class StatusDAO
    {

        public static List<StatusModel> GetListaStatus(int status)
        {
            string query = @"SELECT 
	                            cd_Status, 
	                            ds_Status
                            FROM Status
                            WHERE ic_Ativo = 1";
            if (status != 0)
            {
                query += $"AND cd_Status = {status}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<StatusModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var statusModel = new StatusModel();
                    statusModel.CodigoStatus = int.Parse(row["cd_Status"].ToString());
                    statusModel.Descricao = row["ds_Status"].ToString();
                    list.Add(statusModel);
                }
            }
            return list;
        }
    }
}