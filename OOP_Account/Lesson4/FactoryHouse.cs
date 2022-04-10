
namespace Lesson4
{
    internal class FactoryHouse : FactoryAbstract
    {
        private float _height;
        private int _floors;
        private readonly int _rooms;

        public FactoryHouse( float height, int floors, int rooms)
        {
            _height = height;
            _floors = floors;
            _rooms = rooms;
        }


        public override Building CreateHouse()
        {
            return new House(_height, _floors, _rooms);
        }
    }
}
