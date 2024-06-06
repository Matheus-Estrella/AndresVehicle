using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Operation : Generic
    {
        #region Características para interação com Generic e o sistema
        // Para o gerador de arquivos json desta classe
        readonly string path = @"C:\Users\Matheus\TrabalhosEstagio\AndresVehicles";
        readonly string file = @"\Services.json";
        // Para manipular a tabela do banco de dados sql
        readonly string _tableName = "TB_Servicos";
        readonly string _inforRestrained = "_id";

        public override string GetPath() { return path; }
        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }
        #endregion

        public int _id { get; set; }
        public string _operation { get; set; }




        readonly List<string> _operations = new()
            {
                    "Limpeza interna",
                "Repintura",
                "Martelinho de ouro",
                "Ajuste do freio",
                "Troca de óleo",
                "Alinhamento e balanceamento",
                "Troca de pneus",
                "Troca de bateria",
                "Reparo de motor",
                "Substituição de peças",
                "Recarga do ar condicionado",
                "Verificação de sistema elétrico",
                "Balanceamento de rodas",
                "Alinhamento de direção",
                "Troca de filtro de ar",
                "Revisão do sistema de suspensão",
                "Reparo de sistema de transmissão",
                "Substituição de pastilhas de freio",
                "Verificação de sistema de ignição",
                "Troca de correia dentada",
                "Troca de fluido de freio",
                "Verificação e ajuste de sistema de escapamento"
            };
        public Operation()
        {
            Console.Clear();
            Console.WriteLine("Escolha de uma das opções abaixo, o serviço realizado");
            int count = 1;
            foreach (string _operation in _operations)
            {
                Console.WriteLine($" [{count}] - {_operation}");
                count++;
            }
            Console.Write("\n\nDigite o código do tipo do serviço: ");
            this._id = int.Parse(Console.ReadLine());
            this._operation = _operations[_id];
        }

    }
}
