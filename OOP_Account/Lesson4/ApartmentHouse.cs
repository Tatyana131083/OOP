
namespace Lesson4
{
    internal class ApartmentHouse : Building
    {

        //количество квартир
        public int Flats { get; set; }

        //количество подъездов
        public int Entrances { get; set; }

        public ApartmentHouse(float height, int floors, int flats, int entrances) : base(height, floors)
        {
            Flats = flats;
            Entrances = entrances;
        }
       


        /// <summary>
        /// Количество квартир в подъезде
        /// </summary>
        /// <returns>Количество квартир</returns>
        public int CountApartmentsInEntrance()
        {
            return Flats / Entrances;
        }

        /// <summary>
        /// Количество квартир на этаже
        /// </summary>
        /// <returns>Количество квартир</returns>
        public int CountApartmentsOnFloor()
        {
            return Flats / Entrances / Floors;
        }


    }
}
