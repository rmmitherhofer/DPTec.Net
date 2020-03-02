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
    public class FolhaPontoDAO
    {
        public static List<PontoModel> GetListaPonto(PontoModel ponto)
        {
            string query = $@"SELECT
                                cd_ponto,
                                cd_Matricula,
                                nm_Funcionario,
                                ds_Cargo,
                                ds_Departamento,
                                ds_Mes,
                                ds_Competencia,
                                cd_Status,
                                hr_Saldo_Referencia,
                                hr_Saldo,
                                ds_Status,
                                dt_PeriodoInicio,
                                dt_PeriodoFim
                            FROM DPTec..vwPonto";
            if (ponto.Matricula == 0)
            {
                query += $@" WHERE ds_Mes = {ponto.Mes}
                    AND YEAR(dt_PeriodoInicio) = {ponto.Ano}
                    AND ds_Status = '{ponto.StatusPonto}'";
            }
            else
            {
                query += $@" WHERE cd_Matricula = {ponto.Matricula}
                    AND ds_Mes = {ponto.Mes}
                    AND YEAR(dt_PeriodoInicio) = {ponto.Ano}";
            }

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<PontoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var PontoDados = new PontoModel();
                    PontoDados.CodigoPonto = int.Parse(row["cd_ponto"].ToString());
                    PontoDados.Matricula = int.Parse(row["cd_Matricula"].ToString());
                    PontoDados.NomeFuncionario = row["nm_Funcionario"].ToString();
                    //PontoDados.Cargo = int.Parse(row["ds_Cargo"].ToString());
                    //PontoDados.Departamento = int.Parse(row["ds_Departamento"].ToString());
                    //PontoDados.Mes = int.Parse(row["ds_Mes"].ToString());
                    PontoDados.Competencia = row["ds_Competencia"].ToString();
                    PontoDados.StatusPonto = row["ds_Status"].ToString();
                    PontoDados.SaldoReferencia = row["hr_Saldo_Referencia"].ToString();
                    PontoDados.Saldo = row["hr_Saldo"].ToString();
                    //PontoDados. = int.Parse(row["ds_Status"].ToString());
                    PontoDados.DataPeriodoInicio = DateTime.Parse(row["dt_PeriodoInicio"].ToString());
                    PontoDados.DataPeriodoFim = DateTime.Parse(row["dt_PeriodoFim"].ToString());
                    list.Add(PontoDados);
                }
            }
            return list;
        }

        public static List<DetalhamentoPontoModel> GetRelatorioPonto(DetalhamentoPontoModel detalhamento, string op)
        {
            string query = $@"EXEC sp_CalculoPonto 
                            @Month = {detalhamento.Mes},
                            @Year = {detalhamento.Ano},
                            @cdFunc = {detalhamento.Matricula},
                            @cdPonto = {detalhamento.CodigoPonto}";
            if (!String.IsNullOrEmpty(op))
            {
                query += $"@Op = {op}";
            } 

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<DetalhamentoPontoModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var marcacaoModel = new DetalhamentoPontoModel();
                    marcacaoModel.CodigoPonto = int.Parse(row["cd_ponto"].ToString());
                    marcacaoModel.Matricula = int.Parse(row["cd_Matricula"].ToString());
                    marcacaoModel.NomeFuncionario = row["nm_Funcionario"].ToString();
                    //marcacaoModel.Cargo = int.Parse(row["ds_Cargo"].ToString());
                    //marcacaoModel.Departamento = int.Parse(row["ds_Departamento"].ToString());
                    //marcacaoModel.Mes = int.Parse(row["ds_Mes"].ToString());
                    marcacaoModel.Competencia = row["ds_Competencia"].ToString();
                    marcacaoModel.StatusPonto = row["ds_Status"].ToString();
                    marcacaoModel.SaldoReferencia = row["hr_Saldo_Referencia"].ToString();
                    marcacaoModel.Saldo = row["hr_Saldo"].ToString();
                    //marcacaoModel. = int.Parse(row["ds_Status"].ToString());
                    marcacaoModel.DataPeriodoInicio = DateTime.Parse(row["dt_PeriodoInicio"].ToString());
                    marcacaoModel.DataPeriodoFim = DateTime.Parse(row["dt_PeriodoFim"].ToString());

                    marcacaoModel.Data = DateTime.Parse(row["dt_Data"].ToString());
                    marcacaoModel.Semana = row["Dia"].ToString();
                    marcacaoModel.HoraEntradaPadrao = row["Horario_Entrada"].ToString();
                    marcacaoModel.HoraSaidaAlmocoPadrao = row["Horario_Almoco"].ToString();
                    marcacaoModel.HoraVoltaAlmocoPadrao = row["Horario_Retorno_Almoco"].ToString();
                    marcacaoModel.HoraSaidaPadrao = row["Horario_Saida"].ToString();
                    marcacaoModel.HoraEntrada = row["Marcacoes_Realizadas_Entrada"].ToString();
                    marcacaoModel.HoraSaidaAlmoco = row["Marcacoes_Realizadas_Almoco"].ToString();
                    marcacaoModel.HoraVoltaAlmoco = row["Marcacoes_Realizadas_RetornoAlmoco"].ToString();
                    marcacaoModel.HoraSaida = row["Marcacoes_Realizadas_Saida"].ToString();
                    //marcacaoModel.horat = row["HoraTrabalhada"].ToString();
                    //marcacaoModel.HoraAlmoco = row["HoraAlmoco"].ToString();
                    marcacaoModel.HoraAdicional = row["HoraAdicional"].ToString();
                    list.Add(marcacaoModel);
                }
            }
            return list;
        }

        public static string MarcarPonto(int matricula)
        {
            string query = $@"EXEC sp_GerarPonto @cdMatricula = {matricula}";

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            string message = null;
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    message = row["msg"].ToString();
                }
            }
            return message;
        }
    }
}