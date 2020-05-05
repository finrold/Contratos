using Contratos.Entities.Enums;
using System.Collections.Generic;
using Contratos.Entities;

namespace Contratos.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();
    
        public Trabalhador()
        {

        }

        public Trabalhador(string nome, WorkerLevel level, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(HoraContrato contratos)
        {
            Contratos.Add(contratos);
        }

        public void RemoveContrato(HoraContrato contratos)
        {
            Contratos.Remove(contratos);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HoraContrato contratos in Contratos)
            {
                if (contratos.Data.Year == ano && contratos.Data.Month == mes)
                {
                    soma += contratos.ValorTotal();
                }
            }
            return soma;
        }
    }
}
