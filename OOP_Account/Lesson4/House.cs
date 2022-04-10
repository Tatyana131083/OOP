
namespace Lesson4
{
    internal class House : Building
    {
        //количество комнат
        public int Rooms { get; set; }

        public House(float height, int floors, int rooms) : base(height, floors)
        {
            Rooms = rooms;
        }


        /// <summary>
        /// Количество комнат на этаже
        /// </summary>
        /// <returns>Количество комнат</returns>
        public int CountRoomsOnFloor()
        {
            return Rooms / Floors;
        }
    }
}
