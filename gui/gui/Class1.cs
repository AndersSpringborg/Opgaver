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
            //Her oprettes vores byer (Database)
            City Aalborg = new City("Aalborg", 150, 200);
            City Aarhus = new City("Aarhus", 150, 350);
            City Frederikshavn = new City("Frederikshavn", 250, 200);

            //Opretter buttons for byerne
            this.Controls.Add(NewButton(Aalborg));
            this.Controls.Add(NewButton(Aarhus));
            this.Controls.Add(NewButton(Frederikshavn));

            // Item1 = by1     |      Item2 = vægt      |   Item3 = by2;
            var Relationer = new List<Tuple<City, int, City>>();
        }
        
        //Laver en knude i form af en button, og returnere den
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
