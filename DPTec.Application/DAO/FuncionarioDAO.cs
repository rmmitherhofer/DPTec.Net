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
    public class FuncionarioDAO
    {
        public static List<FuncionarioModel> GetListaFuncionario(FuncionarioModel funcionario)
        {
            string query = @"SELECT
	                            Func_cd_Matricula,
	                            Func_nm_Funcionario,
	                            Func_cno_Telefone,
	                            Func_no_TelCelular,
	                            Func_no_TelComercial,
	                            Func_no_Ramal,
	                            Func_ds_email,
	                            Func_ds_emailCom,
	                            Func_nm_Mae,
	                            Func_nm_Pai,
	                            Func_ds_Nacionalidade,
	                            Func_ds_Naturalidade,
	                            Func_dt_Nascimento,
	                            Func_ds_Sexo,
	                            Func_cd_EstadoCivil,
	                            EstCivil_DS_ESTADOCIVIL,
	                            Func_nm_Conjuge,
	                            Func_ds_NecesEspecial,
	                            Func_no_CTPS,
	                            Func_no_Serie,
	                            Func_sg_UF_CTPS,
	                            Func_dt_Expedicao,
	                            Func_no_PIS,
	                            Func_no_RG,
	                            Func_ds_OrgExp,
	                            Func_dt_Expedicao_RG,
	                            Func_no_CPF,
	                            Func_no_Tit_Eleitor,
	                            Func_no_Zona,
	                            Func_no_Secao,
	                            Func_no_Reservista,
	                            Func_no_RA_Reservista,
	                            Func_sg_Serie_Reservista,
	                            Func_ts_Admissao,
	                            Func_ts_Desligamento,
	                            Func_cd_Cargo,
	                            Carg_DS_CARGO,
	                            Func_cd_Departamento,
	                            Dep_DS_DEPARTAMENTO,
	                            Dep_CD_CCUSTO,
	                            Dep_CD_MATRICULA,
	                            Gest_NM_FUNCIONARIO,
	                            Carg_Gestor,
	                            Func_tp_Contrato,
	                            Func_no_CEP,
	                            End_NM_LOGRADOURO,
	                            Func_no_Endereco,
	                            Func_nm_Complemento,
	                            End_NM_BAIRRO,
	                            End_NM_CIDADE,
	                            End_SG_UF,
	                            End_NM_PAIS,
	                            Func_cd_Status,
	                            Stat_DS_STATUS,
	                            emp_Empresa
                            FROM DPTec..vwConsultaFuncionario
                            WHERE 1=1";
            if (funcionario.NumCPF != 0)
            {
                query += ($"AND Func_no_CPF = {funcionario.NumCPF}");
            }
            if (!"".Equals(funcionario.Matricula) && funcionario.Matricula != 0)
            {
                query += ($"AND Func_cd_Matricula = {funcionario.Matricula}");
            }
            if (!String.IsNullOrEmpty(funcionario.NomeFuncionario))
            {
                query += ($"AND Func_nm_Funcionario like '%{funcionario.NomeFuncionario}%'");
            }
            if (funcionario.NumRG != 0)
            {
                query += ($"AND Func_no_RG = '{funcionario.NumRG}'");
            }
            if (funcionario.NumPIS != 0)
            {
                query += ($"AND Func_no_PIS = '{funcionario.NumPIS}'");
            }
            //if (!"Selecionar".Equals(funcionario.Departamento) && funcionario.Departamento != null)
            //{
            //    query += ($"AND Dep_DS_DEPARTAMENTO = '{funcionario.Departamento}'");
            //}
            //if (!"Selecionar".Equals(funcionario.Cargo) && funcionario.Cargo != null)
            //{
            //    query += ($"AND Carg_DS_CARGO = '{funcionario.Cargo}'");
            //}
            //if (!"Selecionar".Equals(funcionario.Status) && funcionario.Status != null)
            //{
            //    query += ($"AND Stat_DS_STATUS = '{funcionario.Status}'");
            //}
            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPTec"].ConnectionString);
            SqlCommand command = new SqlCommand { CommandText = query, Connection = conn };
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);

            var list = new List<FuncionarioModel>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var funcionarioDados = new FuncionarioModel();
                    funcionarioDados.Matricula = int.Parse(row["Func_cd_Matricula"].ToString());
                    funcionarioDados.NomeFuncionario = row["Func_nm_Funcionario"].ToString();
                    funcionarioDados.NumTelefone = long.Parse(row["Func_cno_Telefone"].ToString());
                    funcionarioDados.NumTelCelular = long.Parse(row["Func_no_TelCelular"].ToString());
                    funcionarioDados.NumTelComercial = long.Parse(row["Func_no_TelComercial"].ToString());
                    funcionarioDados.NumRamal = int.Parse(row["Func_no_Ramal"].ToString());
                    funcionarioDados.Email = row["Func_ds_email"].ToString();
                    funcionarioDados.EmailComercial = row["Func_ds_emailCom"].ToString();
                    funcionarioDados.NomeMae = row["Func_nm_Mae"].ToString();
                    funcionarioDados.NomePai = row["Func_nm_Pai"].ToString();
                    funcionarioDados.Nacionalidade = row["Func_ds_Nacionalidade"].ToString();
                    funcionarioDados.Naturalidade = row["Func_ds_Naturalidade"].ToString();
                    funcionarioDados.DataNascimento = row["Func_dt_Nascimento"].ToString();
                    funcionarioDados.Sexo = row["Func_ds_Sexo"].ToString();
                    //Func_cd_EstadoCivil
                    funcionarioDados.EstadoCivil = row["EstCivil_DS_ESTADOCIVIL"].ToString();
                    funcionarioDados.NomeConjuge = row["Func_nm_Conjuge"].ToString();
                    funcionarioDados.PCD = row["Func_ds_NecesEspecial"].ToString();
                    funcionarioDados.NumCTPS = long.Parse(row["Func_no_CTPS"].ToString());
                    funcionarioDados.NumSerie = int.Parse(row["Func_no_Serie"].ToString());
                    funcionarioDados.UFCTPS = row["Func_sg_UF_CTPS"].ToString();
                    funcionarioDados.DataExpedicaoCTPS =row["Func_dt_Expedicao"].ToString();
                    funcionarioDados.NumPIS = long.Parse(row["Func_no_PIS"].ToString());
                    funcionarioDados.NumRG = long.Parse(row["Func_no_RG"].ToString());
                    funcionarioDados.OrgaoExpeditor = row["Func_ds_OrgExp"].ToString();
                    funcionarioDados.DataExpedicaoRG = row["Func_dt_Expedicao_RG"].ToString();
                    funcionarioDados.NumCPF = long.Parse(row["Func_no_CPF"].ToString());
                    funcionarioDados.NumTituloEleitor = long.Parse(row["Func_no_Tit_Eleitor"].ToString());
                    funcionarioDados.NumZonaEleitor = int.Parse(row["Func_no_Zona"].ToString());
                    funcionarioDados.NumSecaoEleitor = int.Parse(row["Func_no_Secao"].ToString());
                    funcionarioDados.NumReservista = long.Parse(row["Func_no_Reservista"].ToString());
                    funcionarioDados.NumRAReservista = long.Parse(row["Func_no_RA_Reservista"].ToString());
                    funcionarioDados.SiglaSerieReservista = row["Func_sg_Serie_Reservista"].ToString();
                    funcionarioDados.DataAdmissao = row["Func_ts_Admissao"].ToString();
                    funcionarioDados.DataDesligamento = row["Func_ts_Desligamento"].ToString();
                    funcionarioDados.CodigoCargo = int.Parse(row["Func_cd_Cargo"].ToString());
                    funcionarioDados.Cargo = row["Carg_DS_CARGO"].ToString();
                    funcionarioDados.Departamento = int.Parse(row["Func_cd_Departamento"].ToString());
                    ////Dep_DS_DEPARTAMENTO
                    ////Dep_CD_CCUSTO
                    ////Dep_CD_MATRICULA
                    ////Gest_NM_FUNCIONARIO
                    ////Carg_Gestor
                    funcionarioDados.TipoContrato = row["Func_tp_Contrato"].ToString();
                    funcionarioDados.numCEP = row["Func_no_CEP"].ToString();
                    funcionarioDados.NumEndereco = row["Func_no_Endereco"].ToString();
                    funcionarioDados.Complemento = row["Func_nm_Complemento"].ToString();
                    ////End_NM_BAIRRO
                    ////End_NM_CIDADE
                    ////End_SG_UF
                    ////End_NM_PAIS
                    //Func_cd_Status
                    funcionarioDados.StatusFuncionario = row["Stat_DS_STATUS"].ToString();
                    funcionarioDados.Empresa = row["emp_Empresa"].ToString();
                    list.Add(funcionarioDados);
                }                
            }
            return list;
        }

        public void Incluir()
        {
        }

        public void Alterar()
        {
        }

        public void Inativa()
        {
        }
    }
}