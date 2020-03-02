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
    public class PerfilDAO
    {
        public static List<PerfilModel> GetListaPerfil(PerfilModel perfil)
        {
            string query = $@" SELECT 
                                U.cd_Usuario, 
                                U.ds_Login,
                                U.nm_Usuario,
                                U.cd_Matricula,
                                P.cd_Perfil,
                                P.ds_Liberacao, 
                                P.ic_Ativo,
                                P.tp_Perfil
                            FROM DPtec..Usuario U 
                                INNER JOIN PerfilUsuario PU ON PU.cd_Usuario = U.cd_Usuario 
                                INNER JOIN Perfil P ON P.cd_Perfil = PU.cd_Perfil AND P.ic_Ativo = 1 AND ds_Sistema LIKE 'DPTec'
                                LEFT JOIN Funcionario F ON F.cd_Matricula = U.cd_Matricula
                            WHERE U.cd_Usuario = {perfil.CodigoUsuario}";

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<PerfilModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var perfilModel = new PerfilModel();
                    perfilModel.CodigoUsuario = int.Parse(row["cd_Usuario"].ToString());
                    perfilModel.Login = row["ds_Login"].ToString();
                    perfilModel.NomeUsuario = row["nm_Usuario"].ToString();
                    perfilModel.Matricula = int.Parse(row["cd_Matricula"].ToString());
                    perfilModel.CodigoPerfil = int.Parse(row["cd_Perfil"].ToString());
                    perfilModel.DescLiberacao =row["ds_Liberacao"].ToString();
                    perfilModel.Ativo = bool.Parse(row["ic_Ativo"].ToString());
                    perfilModel.TipoPerfil = row["tp_Perfil"].ToString();
                    list.Add(perfilModel);
                }
            }
            return list;
        }
    }
}