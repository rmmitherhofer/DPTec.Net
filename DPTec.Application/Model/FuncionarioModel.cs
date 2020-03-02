using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class FuncionarioModel
    {
        public int Matricula { get; set; }
        public string NomeFuncionario { get; set; }
        public long NumTelefone { get; set; }
        public long NumTelCelular { get; set; }
        public long NumTelComercial { get; set; }
        public int NumRamal { get; set; }
        public string Email { get; set; }
        public string EmailComercial { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public string PCD { get; set; }
        public long NumCTPS { get; set; }
        public long NumSerie { get; set; }
        public string UFCTPS { get; set; }
        public string DataExpedicaoCTPS { get; set; }
        public long NumPIS { get; set; }
        public long NumRG { get; set; }
        public string OrgaoExpeditor { get; set; }
        public string DataExpedicaoRG { get; set; }
        public long NumCPF { get; set; }
        public long NumTituloEleitor { get; set; }
        public int NumZonaEleitor { get; set; }
        public int NumSecaoEleitor { get; set; }
        public long NumReservista { get; set; }
        public long NumRAReservista { get; set; }
        public string SiglaSerieReservista { get; set; }
        public string DataAdmissao { get; set; }
        public string DataDesligamento { get; set; }
        public int CodigoCargo { get; set; }
        public string Cargo { get; set; }
        public int Departamento { get; set; }
        public string TipoContrato { get; set; }
        public string numCEP { get; set; }
        public string NumEndereco { get; set; }
        public string Complemento { get; set; }
        public string StatusFuncionario { get; set; }
        public string Empresa { get; set; }

        public FuncionarioModel(int matricula)
        {
            Matricula = matricula;
        }
        public FuncionarioModel()
        {
        }
    }
}