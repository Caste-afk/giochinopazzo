using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoAddestramentoPuffi
{
    struct Punto
    {
        public int X;
        public int Y;

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Muovi(int dir)
        {
            switch (dir)
            {
                case 0://su
                    Y = Y+40;
                    break;
                case 1://destra
                    X = X + 40;
                    break;
                case 2://giu
                    Y = Y - 40;
                    break;
                case 3:
                    X = X - 40;
                    break;
            }
        }

    }
    public partial class Form1 : Form
    {
        private Punto player;
        public Form1()
        {
            InitializeComponent();
            Punto player = new Punto(pnl_player.Location.X, pnl_player.Location.Y);
        }

        private void btn_destra_Click(object sender, EventArgs e)
        {
            player.Muovi(1);
        }

        private void btn_su_Click(object sender, EventArgs e)
        {

        }

        private void btn_giu_Click(object sender, EventArgs e)
        {

        }

        private void btn_sinistra_Click(object sender, EventArgs e)
        {

        }


    }
}
