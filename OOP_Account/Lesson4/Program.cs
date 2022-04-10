using System;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            ApartmentHouse building1 = (ApartmentHouse)creator.CreateBuilding(new FactoryApartmentHouse(36, 9, 360, 10));
            ApartmentHouse building2 = (ApartmentHouse)creator.CreateBuilding(new FactoryApartmentHouse(1.5f, 5, 90, 3));
            House building3 = (House)creator.CreateBuilding(new FactoryHouse(8, 2, 10));
            House building4 = (House)creator.CreateBuilding(new FactoryHouse(7.6f, 2, 6));

            Console.WriteLine($"building1: id - {building1.Id}; floors - {building1.Floors}; flats - {building1.Flats}; ");
            Console.WriteLine($"Count of flats on floor: {building1.CountApartmentsOnFloor()}");
            Console.WriteLine($"Count of flats in entrancer: {building1.CountApartmentsInEntrance()}");
            Console.WriteLine($"building3: id - {building3.Id}; floors - {building3.Floors}; flats - {building3.Rooms}; ");
            Console.WriteLine($"Height of floor: {building3.HeightOfFloor()}");

            creator.DeleteBuilding(2);
            Console.WriteLine($"Count of buildings - {creator.HouseTable.Count}");
        }

        
    }
}
