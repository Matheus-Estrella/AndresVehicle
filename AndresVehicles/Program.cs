
using Controller;
using Generator;
using Injection;
using Models;

#region
SqlInjection inject = new SqlInjection();
inject.OperationsTabletCreator();
inject.DB_CarInject();
#endregion

RandomGenerator list = new RandomGenerator(); // Para criação de listas
#region CARROS A SER COMPRADO
list.CarListCreator();
#endregion

#region

#endregion

