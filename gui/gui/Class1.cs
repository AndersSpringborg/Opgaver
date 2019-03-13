using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace gui
{
    class Form1 : Form
    {
        public Form1 ()
        {
            City Aalborg = new City("Aalborg", 150, 200);
            City Aarhus = new City("Aarhus", 150, 350);
            City Frederikshavn = new City("Frederikshavn", 250, 200);

            this.Controls.Add(NewButton(Aalborg));
            this.Controls.Add(NewButton(Aarhus));
            this.Controls.Add(NewButton(Frederikshavn));

            // Item1 = by1     |      Item2 = vægt      |   Item3 = by2;
            var Relationer = new List<Tuple<City, int, City>>();
        }
        
        private Button NewButton(City NewCity)
        {
            Button NewButton = new Button();
            NewButton.Location = new Point(NewCity.CoordinateX, NewCity.CoordinateY);
            NewButton.Size = new Size(100, 100);
            NewButton.Text = NewCity.Name;
            return NewButton;
        }
    }
}
