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
    public class EstadoCivilDAO
    {
        public static List<EstadoCivilModel> GetEstadoCivil(int estadoCivil)
        {
            string query = $@"SELECT 
	                            cd_EstadoCivil, 
	                            ds_EstadoCivil
                            FROM DPtec..EstadoCivil
                            WHERE ic_Ativo = 1";
            if (estadoCivil != 0)
            {
                query += $@"AND cd_EstadoCivil = '{estadoCivil}'";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<EstadoCivilModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var estadoCivilModel = new EstadoCivilModel();
                    estadoCivilModel.CodigoEstadoCivil = int.Parse(row["cd_EstadoCivil"].ToString());
                    estadoCivilModel.EstadoCivil = row["ds_EstadoCivil"].ToString();
                    list.Add(estadoCivilModel);
                }
            }
            return list;
        }
    }
}