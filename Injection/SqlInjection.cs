using Controller;
using Generator;
using Models;
namespace Injection
{
    public class SqlInjection
    {

        public void OperationsTabletCreator()
        {
            List<string> _operations = new()
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
            List<Operation> _ops = new List<Operation>();
            for (int i = 0; i < _operations.Count; i++)
            {
                Operation _op = new Operation();
                _ops.Add(_op);
            }
            foreach (Operation op in _ops)
            {
                new GenericController().Insert(op);
            }
        }
        public void DB_CarInject()
        {
            var lst = ReadFiles.GetData<Car>();
            int count = 1;
            foreach (var car in lst)
            {
                if (new GenericController().Insert(car))
                {
                    Console.WriteLine($"[{count}º] Veículo Adicionado !!!");
                }
                else
                {
                    Console.WriteLine($"[{count}º] Erro ao adicionar veículo  !!!");
                }
                count++;
            }
        }
    }
}
