using GameClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void creatObjectsBtn_Click(object sender, EventArgs e)
        {
            Thing th1;
            Thing th2;
            Treasure tr1;
            Treasure tr2;
            Room r1;
            Room r2;

            th1 = new Thing("A broom: ", "Looks like a broom");
            th2 = new Thing("A shadow  ", "Thats a weird looking shadow");
            tr1 = new Treasure("Writ's leg: ", "Wonder where's Writ", 100);
            tr2 = new Treasure("Ring of recoil: ", "Don't break it!", 250.50);
            r1 = new Room("Dark Room: ", "A room that nobody shall enter", 1, 4, 7, 8);
            r2 = new Room("Rabbit Hole: ", "A hole where the evil bunny resides", 1, 4, 6, 3);

            textBox1.Text = "Here we go!\r\n" +
                th1.Name + th1.Description + "\r\n" +
                th2.Name + th2.Description + "\r\n" +
                tr1.Name + tr1.Description + " which is worth Gr" + tr1.Value + "\r\n" +
                tr2.Name + tr2.Description + " which is worth Gr" + tr2.Value + "\r\n" +
                "You can see the " + r1.Name + r1.Description + " with exits to " + r1.N + ", " + r1.S + ", " + r1.W + " and " + r1.E + " and " +
                r2.Name + r2.Description + " with exits to " + r2.N + ", " + r2.S + ", " + r2.W + " and " + r2.E;
        }
    }
}
