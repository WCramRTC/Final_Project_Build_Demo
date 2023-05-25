using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Build_Demo
{
    internal class Boat
    {

        string _name;
        int _speed;

        public Boat(string name, int speed = 0)
        {
            _name = name;
            _speed = speed;
        }

        // new Boat("SSLetzSea"); set the speed value to the default of 0
        // new Boat("SeeLetzSea", 15); sets the speed value to 15

        public string Name { get => _name; set => _name = value; }

        public void Accelerate(int speedToAccelerate)
        {
            _speed += speedToAccelerate;
        }

        public override string ToString()
        {
            return $"{_name} - Current Speed: {_speed}";
        }
    }
}
