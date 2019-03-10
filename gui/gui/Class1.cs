using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace gui
{
    class Form1 : Form
    {
        public Button button1;
        public Form1 ()
        {
            button1 = new Button();
            button1.Size = new Size(100, 100);
            button1.Location = new Point(100, 100);
            button1.Text = "Press me";
            Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);

            Size = new Size(300, 300);
        }
        private void button1_Click (object sender, System.EventArgs e)
        {
            // Finder den form hvor knappen bliver trykket på
            Form myForm = button1.FindForm();
            // Laver titlen på programmet om
            myForm.Text = "The Form of My Control";
            //Laver baggrundsfarven om
            myForm.BackColor = Color.Red;
            //Laver en textbox, ligesom fejlbox
            MessageBox.Show("hej bøsser");
        }
    }
}
