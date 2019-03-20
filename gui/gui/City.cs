using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace gui
{
    class City
    {
        public City(string name, int x, int y)
        {
            this.Name = name;
            //this.Size = size;
            this.CoordinateX = x;
            this.CoordinateY = y;
        }
        public string Name { get; set; }
        //public int Size {get; set;}
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public List<Tuple<City, int, City>> Adjacent = new List<Tuple<City, int, City>>();
        
    }
}