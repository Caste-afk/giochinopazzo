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
        private Punto enemy;
        private Punto casa;

        public bool turno = true; // true = Puffo, false = Gargamella
        public int punteggiopuffo = 0;
        public int punteggiogargamella = 0;

        public Form1()
        {
            InitializeComponent();
            Spawn();
            player = new Punto(pnl_player.Location.X, pnl_player.Location.Y);
            enemy = new Punto(pnl_gargamella.Location.X, pnl_gargamella.Location.Y);
        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                player.Muovi(0);
                AggiornaPosizione(pnl_player, player);
            }
            else
            {
                enemy.Muovi(0);
                AggiornaPosizione(pnl_gargamella, enemy);
            }
        }

        private void btn_destra_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                player.Muovi(1);
                AggiornaPosizione(pnl_player, player);
            }
            else
            {
                enemy.Muovi(1);
                AggiornaPosizione(pnl_gargamella, enemy);
            }
        }


        private void btn_giu_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                player.Muovi(2);
                AggiornaPosizione(pnl_player, player);
            }
            else
            {
                enemy.Muovi(2);
                AggiornaPosizione(pnl_gargamella, enemy);
            }
        }

        private void btn_sinistra_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                player.Muovi(3);
                AggiornaPosizione(pnl_player, player);
            }
            else
            {
                enemy.Muovi(3);
                AggiornaPosizione(pnl_gargamella, enemy);
            }
        }

        private void AggiornaPosizione(Panel oggetto, Punto nome )
        {
            oggetto.Location = new Point(nome.X, nome.Y); //uso il new Point per...
            bool preso = ControllaPunto();
            if (preso)
            {
                Spawn();
            }
            turno = !turno;
        }


        //------------------------------------ERRORE QUI------------------------------------|
        private void Spawn()
        {
            Random rnd = new Random();
            int x = 0;
            int y = 0;
            Punto[] punti = {player, enemy, casa};
            Panel[] pannelli = { pnl_player, pnl_gargamella, pnl_casa };

            for (int i = 0; i < punti.Length; i++)
            {
                do
                {
                    x = rnd.Next(0, 501);
                } while (x % 40 != 0);

                do
                {
                    y = rnd.Next(0, 381);
                } while (y % 40 != 0);

                punti[i] = new Punto(x, y);
                pannelli[i].Location = new Point(punti[i].X, punti[i].Y);
            }
        }
        //------------------------------------ERRORE QUI------------------------------------|

        private bool ControllaPunto()
        {
            bool preso = false;
            MessageBox.Show($"posizione puffo: {player.X}, {player.Y} | posizione gargamella: {enemy.X}, {enemy.Y} | posizione casa: {casa.X}, {casa.Y}");
            if (player.X == casa.X && player.Y == casa.Y)
            {
                preso = true;
                punteggiopuffo++;
            }

            if (player.X == enemy.X && player.X == enemy.Y)
            {
                preso = true;
                punteggiogargamella++;
                punteggiopuffo--;
            }


            lbl_punteggiog.Text = punteggiogargamella.ToString();
            lbl_punteggiop.Text = punteggiopuffo.ToString();

            return preso;
        }
    }
}
