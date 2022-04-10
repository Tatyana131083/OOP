
namespace Lesson4
{
    internal class Building
    {
        static private int _number;
        //id дома
        private readonly int _id;

        //высота дома
        public float Height { get; set; }

        //количество этажей
        public int Floors { get; set; }

        public int Id { get { return _id; } }

        public Building(float height, int floors)
        {
            _id = ++_number;
            Height = height;
            Floors = floors;
        }

        /// <summary>
        /// Высота этажа
        /// </summary>
        /// <returns>Высота</returns>
        public float HeightOfFloor()
        {
            return Height / Floors;
        }


    }
}
