using System.Collections.Generic;

namespace Dealership.Models
{
    public class Car
    {
        public string _makeModel { get; set; }
        public int _price { get; set; }
        public int _miles { get; set; }

        private static List<Car> _instances = new List<Car> {};
        public Car(string makeModel, int price, int miles)
        {
            _makeModel = makeModel;
            _price = price;
            _miles = miles;
            _instances.Add(this);
        }

      public static List<Car> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
       
    }
}
