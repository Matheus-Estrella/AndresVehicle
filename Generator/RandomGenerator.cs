using Controller;
using GenDapperModels;
using Newtonsoft.Json;

namespace Tools
{
    public class RandomGenerator
    {
        private List<string> _collors = new()
        {
            "Preto",
            "Branco",
            "Prata",
            "Cinza",
            "Azul",
            "Vermelho",
            "Vermelho",
            "Verde",
            "Marrom",
            "Amarelo",
            "Laranja",
            "Rosa"
        };
        private List<string> _carModels = new(){
            "Toyota Corolla",
            "Honda Civic",
            "Volkswagen Golf",
            "Ford Focus",
            "Chevrolet Cruze",
            "Hyundai Elantra",
            "Nissan Sentra",
            "Mazda 3",
            "Kia Forte",
            "Subaru Impreza",
            "BMW Série 3",
            "Mercedes-Benz Classe C",
            "Audi A4",
            "Lexus IS",
            "Volvo S60",
            "Tesla Model 3",
            "Fiat Tipo",
            "Renault Megane",
            "Peugeot 308",
            "Citroën C4"
        };
        private List<string> _letters = new()
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M",
            "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        }; 
        private List<string> _names = new()
        {
            "Emma", "Olivia", "Ava", "Sophia", "Isabella",
            "Mia", "Charlotte", "Amelia", "Evelyn", "Abigail",
            "Harper", "Emily", "Elizabeth", "Sofia", "Avery",
            "Ella", "Scarlett", "Grace", "Chloe", "Victoria",
            "Riley", "Aria", "Lily", "Aubrey", "Zoey",
            "Liam", "Noah", "Oliver", "Elijah", "William",
            "James", "Benjamin", "Lucas", "Henry", "Alexander",
            "Mason", "Michael", "Ethan", "Daniel", "Jacob",
            "Logan", "Jackson", "Levi", "Sebastian", "Mateo",
            "Jack", "Owen", "Theodore", "Aiden", "Samuel"
        };
        private List<string> _lastNames = new()
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones",
            "Miller", "Davis", "Garcia", "Rodriguez", "Wilson",
            "Martinez", "Anderson", "Taylor", "Thomas", "Hernandez",
            "Moore", "Martin", "Jackson", "Thompson", "White",
            "Lopez", "Lee", "Gonzalez", "Harris", "Clark",
            "Lewis", "Robinson", "Walker", "Perez", "Hall",
            "Young", "Allen", "Sanchez", "Wright", "King",
            "Scott", "Green", "Baker", "Adams", "Nelson",
            "Hill", "Ramirez", "Campbell", "Mitchell", "Roberts",
            "Carter", "Phillips", "Evans", "Turner", "Torres"
        };
        private List<string> _jobTitles = new()
        {
            "Gerente",
            "Consultor",
            "Vendedor de Veículos",
            "Técnico Automotivo",
            "Recepcionista",
            "Especialista em Marketing",
            "Faxineira",
        };

        public int StringRandomizer(List<string> list)
        {
            return new Random().Next(0, list.Count);
        }
        public int IntRandomizer(int _min, int _max)
        {
            return new Random().Next(_min, _max);
        }

        #region Para geração do carro
        private string MercosulPatternPlateGenerator()
        {
            List<string> letters = _letters;
            return $"" +
                $"{letters[StringRandomizer(letters)]}" +
                $"{letters[StringRandomizer(letters)]}" +
                $"{letters[StringRandomizer(letters)]}" +
                $"{IntRandomizer(1, 9)}" +
                $"{letters[StringRandomizer(letters)]}" +
                $"{IntRandomizer(1, 9)}" +
                $"{IntRandomizer(1, 9)}";
        }
        public Car RandCarGenerator(int _vehicleTimeRange)
        {
            int _maxYear = DateTime.Now.Year;
            int _minYear = DateTime.Now.Year - _vehicleTimeRange;
            int _producedYear = IntRandomizer(_minYear, _maxYear);
            int _modelYear = IntRandomizer(_minYear, _maxYear);
            if (_modelYear < _producedYear)
                _modelYear = _producedYear;
            return new Car(MercosulPatternPlateGenerator(), _carModels[StringRandomizer(_carModels)], _modelYear, _producedYear, _collors[StringRandomizer(_collors)]);
        }
        public void CarListCreator()
        {
            List<Car> vehicles = new();
            Console.Write("\nInsira quantos carros deseja adicionar: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                RandomGenerator car = new();
                vehicles.Add(car.RandCarGenerator(car.IntRandomizer(0, 6)));
            }
            string json = JsonConvert.SerializeObject(vehicles);
            string _CurrentDirectory = Directory.GetCurrentDirectory();
            string _filePath = Path.Combine(_CurrentDirectory, "..", "..", "..", "..", "Vehicles.json");
            File.WriteAllText(_filePath, json);
            Console.WriteLine("Arquivo JSON gerado com sucesso!");
        }
        #endregion

        #region Para geração de serviços
        #endregion

        #region Para geração Pessoa

        #endregion

        #region Para geração de ...

        #endregion

        #region Para geração de ...

        #endregion

        #region Para geração de ...

        #endregion

        #region Para geração de ...

        #endregion


    }
}
