using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class FuncionarioController
    {
        private int _matricula;
        public FuncionarioController(int matricula)
        {
            _matricula = matricula;
        }
        public FuncionarioController(
            string nome, 
            string sexo, 
            string dataNascimento, 
            string nacionalidade, 
            string naturalidade, 
            string estadoCivil, 
            string nomeConjuge,
            string nomeMae,
            string PCD
            )
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            funcionario.NomeFuncionario = nome;
            funcionario.Sexo = sexo;
            funcionario.DataNascimento = dataNascimento;
            funcionario.Nacionalidade = nacionalidade;
            funcionario.Naturalidade = naturalidade;
            funcionario.EstadoCivil = estadoCivil;
            funcionario.NomeConjuge = nomeConjuge;
            funcionario.NomeMae = nomeMae;
            funcionario.PCD = PCD;
        }
        public FuncionarioController()
        {
        }

        public void Cadastrar()
        {
        }

        public void Alterar()
        {
        }

        public void Inativar()
        {
        }

        public List<FuncionarioModel> Consultar()
        {
            FuncionarioModel funcionarioModel = new FuncionarioModel(_matricula);
            var retorno = FuncionarioDAO.GetListaFuncionario(funcionarioModel);
            if (retorno.Any())
            {
                foreach (var f in retorno)
                {
                    return retorno;
                }
                return null;
            }
            else
            {
                throw new Exception("Funcionário não encontrado.");                
            }
        }
    }
}