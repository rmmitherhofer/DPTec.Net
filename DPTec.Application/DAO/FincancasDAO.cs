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
    public class FincancasDAO
    {
        public static List<BancoModel> GetBanco(int codigoBanco)
        {
            string query = $@"SELECT
                                cd_Banco,
                                nm_Banco,
                                sg_Sigla,
                                ds_Competencia,
                                ds_WebSite
                            FROM Banco
                            WHERE ic_Ativo = 1";
            if (codigoBanco != 0)
            {
                query += $@"AND cd_Banco = {codigoBanco}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<BancoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var bancoModel = new BancoModel();
                    bancoModel.CodigoBanco = int.Parse(row["cd_Banco"].ToString());
                    bancoModel.Nome = row["nm_Banco"].ToString();
                    bancoModel.Sigla = row["sg_Sigla"].ToString();
                    bancoModel.Competencia = row["ds_Competencia"].ToString();
                    bancoModel.WebSite = row["ds_WebSite"].ToString();
                    list.Add(bancoModel);
                }
            }
            return list;
        }
        public static List<FinancaModel> GetFinancas(int matricula)
        {
            string query = $@"SELECT
                                cd_Financas,
                                tp_Conta,
                                cd_Banco,
                                no_Agencia,
                                no_Conta,
                                no_Digito,
                                cd_Status,
                                cd_Matricula,
                                vl_Salario
                            FROM DPTec..Financas
                            WHERE cd_Matricula = {matricula}";

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<FinancaModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var financaModel = new FinancaModel();
                    financaModel.CodigoFinanca = int.Parse(row["cd_Financas"].ToString());
                    financaModel.TipoConta = row["tp_Conta"].ToString();
                    financaModel.CodigoBanco = int.Parse(row["cd_Banco"].ToString());
                    financaModel.Agencia = int.Parse(row["no_Agencia"].ToString());
                    financaModel.Conta = long.Parse(row["no_Conta"].ToString());
                    financaModel.Digito = int.Parse(row["no_Digito"].ToString());
                    financaModel.StatusConta = int.Parse(row["cd_Status"].ToString());
                    financaModel.Matricula = int.Parse(row["cd_Matricula"].ToString());
                    financaModel.ValorSalarial = double.Parse(row["vl_Salario"].ToString());
                    list.Add(financaModel);
                }
            }
            return list;
        }
    }
}