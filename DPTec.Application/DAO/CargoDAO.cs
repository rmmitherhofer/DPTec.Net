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
    public class CargoDAO
    {
        public static List<CargoModel> GetCargo(int codigoCargo)
        {
            string query = $@"SELECT
	                            cd_Cargo,
	                            ds_Cargo
                            FROM DPtec..Cargo
                            WHERE ic_Ativo = 1";
            if (codigoCargo != 0)
            {
                query += $@"AND cd_Cargo = {codigoCargo}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<CargoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cargoModel = new CargoModel();
                    cargoModel.CodigoCargo = int.Parse(row["cd_Cargo"].ToString());
                    cargoModel.Cargo = row["ds_Cargo"].ToString();
                    list.Add(cargoModel);
                }
            }
            return list;
        }
    }
}