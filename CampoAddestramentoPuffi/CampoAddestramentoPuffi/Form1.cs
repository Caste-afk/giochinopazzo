using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
                    Y = Y-40;
                    if (Y < 0)
                        Y = 0;
                    break;
                case 1://destra
                    X = X + 40;
                    if (X >= 520)//bisogna sottrarre la dimensione del player
                        X = 520;
                    break;
                case 2://giu
                    Y = Y + 40;
                    if (Y >= 400)// bisogna sottrarre la dimensione del player
                        Y = 400;
                    break;
                case 3:// sinistra
                    X = X-40;
                    if (X < 0)
                        X = 0;
                    break;
            }
        }

    }
    public partial class Form1 : Form
    {
        private Punto player;
        private Punto casa;

        public int punteggio = 0;

        public Form1()
        {
            InitializeComponent();
            SpawnCasa();
            player = new Punto(pnl_player.Location.X, pnl_player.Location.Y);
        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            player.Muovi(0);
            AggiornaPosizionePlayer();
        }

        private void btn_destra_Click(object sender, EventArgs e)
        {
            player.Muovi(1);
            AggiornaPosizionePlayer();
        }


        private void btn_giu_Click(object sender, EventArgs e)
        {
            player.Muovi(2);
            AggiornaPosizionePlayer();
        }

        private void btn_sinistra_Click(object sender, EventArgs e)
        {
            player.Muovi(3);
            AggiornaPosizionePlayer();
        }

        private void AggiornaPosizionePlayer()
        {
            pnl_player.Location = new Point(player.X, player.Y);
            bool preso = ControllaPunto();
            if (preso)
            {
                SpawnCasa();
            }
        }

        private void SpawnCasa()
        {
            Random rnd = new Random();
            int x = 0;
            int y = 0;
            do
            {
                x = rnd.Next(0, 501);
            } while (x % 40 != 0);

            do
            {
                y = rnd.Next(0, 381);
            } while (y % 40 != 0);

            casa = new Punto(x, y);
            pnl_casa.Location = new Point (casa.X, casa.Y);
        }

        private bool ControllaPunto()
        {
            bool preso = false;
            if (player.X == casa.X && player.Y == casa.Y)
            {
                preso = true;
                punteggio++;
                lbl_punteggio.Text = punteggio.ToString();
            }
            return preso;
        }


    }
}
