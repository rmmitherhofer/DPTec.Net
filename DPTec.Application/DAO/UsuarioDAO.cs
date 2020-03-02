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
    public class UsuarioDAO
    {
        public static List<UsuarioModel> GetListaUsuario(UsuarioModel usuario)
        {
            string query = $@" SELECT
                                    cd_Usuario,
                                    nm_Usuario,
                                    ds_Login,
                                    ds_Senha,
                                    cd_Matricula,
                                    ic_Ativo
                                    FROM DPtec..Usuario
                                WHERE ds_Login = '{usuario.Login}'
                                    OR cd_Usuario = {usuario.CodigoUsuario}";
            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<UsuarioModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var usuarioDados = new UsuarioModel();
                    usuarioDados.CodigoUsuario = int.Parse(row["cd_Usuario"].ToString());
                    usuarioDados.NomeUsuario = row["nm_Usuario"].ToString();
                    usuarioDados.Login = row["ds_Login"].ToString();
                    usuarioDados.Senha = row["ds_Senha"].ToString();
                    usuarioDados.Matricula = int.Parse(row["cd_Matricula"].ToString());
                    usuarioDados.Ativo = bool.Parse(row["ic_Ativo"].ToString());
                    list.Add(usuarioDados);
                }
            }
            return list;
        }

        public void InativaUsuario()
        {
        }
    }
}