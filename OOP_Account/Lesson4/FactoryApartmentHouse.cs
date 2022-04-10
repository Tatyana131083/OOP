
namespace Lesson4
{
    internal class FactoryApartmentHouse : FactoryAbstract
    {
        private readonly float _height;
        private readonly int _floors;
        private readonly int _flats;
        private readonly int _entrances;

        public FactoryApartmentHouse(float height, int floors, int flats, int entrances)
        {
            _height = height;
            _floors = floors;
            _flats = flats;
            _entrances = entrances;
        }


        public override Building CreateHouse()
        {
            return new ApartmentHouse(_height, _floors, _flats, _entrances);
        }
    }
}
