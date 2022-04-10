using System;
using System.Collections;

namespace Lesson4
{
    internal class Creator
    {
        private Hashtable _buildingTable;

        public Creator()
        {
            _buildingTable = new Hashtable();
        }
        public Hashtable HouseTable { get { return _buildingTable; } }

        public Building CreateBuilding(FactoryAbstract factoryAbstract)
        {
            Building building =  factoryAbstract.CreateHouse();
            try
            {
                _buildingTable.Add(building.Id, building);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entry already exists.");
            }
            return building;
        }

        /// <summary>
        /// Удаления объекта здания по его уникальному номеру из хеш-таблицы
        /// </summary>
        /// <param name="id">Уникальный номер</param>
        /// <returns>Истина - при успешном удалении, ложь при неуспешном</returns>
        public bool DeleteBuilding(int id)
        {
            if(_buildingTable.Contains(id))
            { 
                _buildingTable.Remove(id);
                return true;
            } else return false;
            
        }
    }
}
