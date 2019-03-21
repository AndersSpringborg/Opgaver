using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {

            InitializeComponent();


            //Her oprettes vores byer (Database)
            City Aalborg = new City("Aalborg", 150, 200);
            City Aarhus = new City("Aarhus", 150, 350);
            City Frederikshavn = new City("Frederikshavn", 250, 200);
                
            // Item1 = by1     |      Item2 = vægt      |   Item3 = by2;
            var Relations = new List<Tuple<City, int, City>>();
            Relations.Add(new Tuple<City, int, City>(Aalborg, 1, Aarhus));
            Relations.Add(new Tuple<City, int, City>(Aalborg, 1, Frederikshavn));

            foreach(Tuple<City, int, City> item in Relations)
            {

                //item.Item1.Adjacent.Add(item);
                //item.Item3.Adjacent.Add(item);
            }




            //Opretter buttons for byerne
            this.Controls.Add(NewButton(Aalborg));
            this.Controls.Add(NewButton(Aarhus));
            this.Controls.Add(NewButton(Frederikshavn));

        }
        
        //Laver en knude i form af en button, og returnere den
        private Button NewButton(City NewCity)
        {
            Button NewButton = new Button();
            NewButton.Location = new Point(NewCity.CoordinateX, NewCity.CoordinateY);
            NewButton.Size = new Size(75, 75);
            NewButton.Text = NewCity.Name;
            return NewButton;
        }

        private void DrawImagePointF(PaintEventArgs e)
        {
            Point[] points =
            {
            new Point(100,100),
            new Point(100,200),
            new Point(200,100)
        };

            e.Graphics.DrawLines(new Pen(Color.Red, 8), points);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1120, 681);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics grafik = new Graphics();


        }
    }
}
