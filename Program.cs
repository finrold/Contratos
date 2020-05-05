using Contratos.Entities.Enums;
using Contratos.Entities;
using System;
using System.Globalization;

namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento: ");
            string deptNome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Trabalhador: ");
            Console.Write("Nome :");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(deptNome);
            Trabalhador trabalhador = new Trabalhador(nome, level, salarioBase, dept);

            Console.Write("Quantos contratos para este trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(data, valorPorHora, horas);
                trabalhador.AddContrato(contrato);
            }
            Console.WriteLine();
            Console.Write("Entre com o mes e ano para calcular o ganho (MM/YYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Ganho de " + mesEAno + ": " + trabalhador.Ganho(ano, mes).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
