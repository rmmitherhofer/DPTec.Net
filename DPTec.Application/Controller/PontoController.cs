using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class PontoController
    {
        private int _ano;
        private int _mes;
        private int _matricula;

        public PontoController(int ano, int mes, int matricula)
        {
            if(ano == 0)
                throw new Exception("Selecione o Ano.");
            if(mes == 0)
                throw new Exception("Selecione o Mes.");
            _ano = ano;
            _mes = mes;
            _matricula = matricula;
        }
        public PontoController(int matricula)
        {
            _matricula = matricula;
        }

        public List<DetalhamentoPontoModel> ListaPonto()
        {
            PontoModel pontoModel = new PontoModel(_mes, _ano, _matricula);
            var pontos = FolhaPontoDAO.GetListaPonto(pontoModel);            

            if (pontos.Any())
            {
                return GetDetalhamentoPonto(pontos);
            }
            else
            {
                throw new Exception("Marcações de Ponto não encontrado Para o mês/ano Selecionado.");
            }
        }

        private List<DetalhamentoPontoModel> GetDetalhamentoPonto(List<PontoModel> pontos)
        {
            foreach (var p in pontos)
            {
                DetalhamentoPontoModel ponto = new DetalhamentoPontoModel(_mes, _ano, _matricula, p.CodigoPonto);
                return FolhaPontoDAO.GetRelatorioPonto(ponto, null);
            }
            return null;
        }

        public string MarcarPonto()
        {
            return FolhaPontoDAO.MarcarPonto(_matricula);
        }

        public void FecharPonto()
        {
        }
    }
}