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
// per scrivere in output
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using CampoAddestramentoPuffi.Properties;

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

        public void Muovi(int dir, Punto[] alberi)
        {
            Punto PosDopo = this;
            switch (dir)
            {
                case 0: // su
                    PosDopo.Y -= 40;
                    break;
                case 1: // destra
                    PosDopo.X += 40;
                    break;
                case 2: // giu
                    PosDopo.Y += 40;
                    break;
                case 3: // sinistra
                    PosDopo.X -= 40;
                    break;
            }

            for (int i = 0; i < alberi.Length; i++)
            {
                if ((PosDopo.X == alberi[i].X && PosDopo.Y == alberi[i].Y) || PosDopo.X > 520 || PosDopo.X < 0 || PosDopo.Y > 400 || PosDopo.Y < 0)
                {
                    Debug.Write($"sbattuto contro ({alberi[i].X}, {alberi[i].Y})");
                    return;
                }
            }
            this = PosDopo;
        }
    }


    public partial class Form1 : Form
    {
        private Punto player;
        private Punto enemy;
        private Punto casa;
        private Punto[] PuntoAlbero;
        private Panel[] pnl_alberi;

        public bool turno = true; // true = Puffo, false = Gargamella
        public int punteggiopuffo = 0;
        public int punteggiogargamella = 0;

        public Form1()
        {

            InitializeComponent();
            SpawnAlberi(); // Genera gli alberi PRIMA di spawnare gli altri elementi
            (player, enemy, casa) = Spawn(); // Spawna casa, giocatore e nemico

            this.KeyDown += new KeyEventHandler(ControlloTastiera);
            this.KeyPreview = true; 
            Debug.WriteLine($"Posizioni - Puffo: [{player.X}, {player.Y}] | Gargamella: [{enemy.X}, {enemy.Y}] | Casa: [{casa.X}, {casa.Y}]");
        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            ControllaTurno(0);
        }

        private void btn_destra_Click(object sender, EventArgs e)
        {
            ControllaTurno(1);
        }

        private void btn_giu_Click(object sender, EventArgs e)
        {
            ControllaTurno(2);
        }

        private void btn_sinistra_Click(object sender, EventArgs e)
        {
            ControllaTurno(3);
        }

        private void ControllaTurno(int n)
        {
            Debug.WriteLine($"Posizioni - Puffo: [{player.X}, {player.Y}] | Gargamella: [{enemy.X}, {enemy.Y}] | Casa: [{casa.X}, {casa.Y}]");
            if (turno)
            {
                player.Muovi(n, PuntoAlbero);
                AggiornaPosizione(pnl_player, player, n);
                lbl_turno.Text = "Gargamella";
            }
            else
            {
                enemy.Muovi(n, PuntoAlbero);
                AggiornaPosizione(pnl_gargamella, enemy, n);
                lbl_turno.Text = "Puffo";
            }
        }

        private void AggiornaPosizione(Panel pannello, Punto punto, int n)
        {
            pannello.Location = new Point(punto.X, punto.Y);
            ControllaPunto(n);
            turno = !turno;
        }
        private void ControllaPunto(int n)
        {
            bool preso = false;
            if (player.X == casa.X && player.Y == casa.Y)
            {
                preso = true;
                punteggiopuffo++;
            }
            else if (player.X == enemy.X && player.Y == enemy.Y)
            {
                preso = true;
                punteggiogargamella++;

                if (punteggiopuffo <= 0)
                {
                    punteggiopuffo = 0;
                }
                else
                {
                    punteggiopuffo--;
                }
            }

            if (preso)
            {
                CancellaAlberi(pnl_alberi);//cancella alberi vecchi
                SpawnAlberi();//rigenera altri alberi
                (player, enemy, casa) = Spawn();
            }

            lbl_punteggiog.Text = punteggiogargamella.ToString();
            lbl_punteggiop.Text = punteggiopuffo.ToString();
        }

        private (Punto player, Punto enemy, Punto casa) Spawn()
        {
            Punto[] punti = { player, enemy, casa }; // array di tutti i punti non alberi
            Panel[] pannelli = { pnl_player, pnl_gargamella, pnl_casa }; // array di tutti i pannelli non alberi

            for (int i = 0; i < punti.Length; i++) // spawna tutti gli elementi in posizioni random
            {
                int x, y;
                bool posizioneValida;

                do
                {
                    posizioneValida = true;
                    (x, y) = CoordinataRandom();

                    // controlla se albero
                    for (int j = 0; j < PuntoAlbero.Length; j++)
                    {
                        if (x == PuntoAlbero[j].X && y == PuntoAlbero[j].Y)
                        {
                            posizioneValida = false;
                        }
                    }

                    // controlla se altri elementi(gargamella, puffo, casa)
                    for (int j = 0; j < i; j++)
                    {
                        if (x == punti[j].X && y == punti[j].Y)
                        {
                            posizioneValida = false;
                        }
                    }
                } while (!posizioneValida);

                punti[i] = new Punto(x, y);
                pannelli[i].Location = new Point(punti[i].X, punti[i].Y);
            }

            // Restituisci le nuove posizioni
            return (punti[0], punti[1], punti[2]);
        }

        private (int x, int y) CoordinataRandom()
        {
            Random rnd = new Random();
            int x, y;

            x = rnd.Next(0, 14) * 40;

            y = rnd.Next(0, 11) * 40;

            return (x, y);
        }

        private void SpawnAlberi()
        {
            PuntoAlbero = new Punto[27];
            pnl_alberi = new Panel[27];

            for (int i = 0; i < PuntoAlbero.Length; i++)
            {
                Random rnd = new Random(Environment.TickCount);

                int n = rnd.Next(1, 7);
                PuntoAlbero[i] = new Punto();

                pnl_alberi[i] = new Panel();
                pnl_alberi[i].Size = new Size(40, 40);
                pnl_alberi[i].BackColor = Color.Green;
                pnl_alberi[i].BackgroundImage = Image.FromFile($"Resources/albero{n}.png");

                int x, y;
                bool posizioneValida;

                do
                {
                    posizioneValida = true;
                    (x, y) = CoordinataRandom();

                    // controlla se alberi
                    for (int j = 0; j < i; j++)
                    {
                        if (x == PuntoAlbero[j].X && y == PuntoAlbero[j].Y)
                        {
                            posizioneValida = false;
                        }
                    }

                    // controlla se altri oggetti
                    if ((x == player.X && y == player.Y) || (x == casa.X && y == casa.Y) || (x == enemy.X && y == enemy.Y))
                    {
                        posizioneValida = false;
                    }
                } while (!posizioneValida);

                PuntoAlbero[i] = new Punto(x, y);
                pnl_alberi[i].Location = new Point(PuntoAlbero[i].X, PuntoAlbero[i].Y);
                pnl_campo.Controls.Add(pnl_alberi[i]);
            }
        }

        private void CancellaAlberi(Panel[] alberi)
        {
            for (int i = 0; i < alberi.Length; i++)
            {
                pnl_campo.Controls.Remove(alberi[i]);
                alberi[i].Dispose();
            }
        }

        private void ControlloTastiera(object sender, KeyEventArgs e)
        {
            string pulsanti;
            if (turno)
            { 
                pulsanti = "WDSA";
            }
            else
            {
                pulsanti = "ILKJ";
            }
            MovimentoTastiera(pulsanti, sender, e);
        }
        

        private void MovimentoTastiera(string pulsanti, object sender, KeyEventArgs e)
        {
            for (int i =0; i < pulsanti.Length; i++)
            {
                if (e.KeyCode == (Keys)pulsanti[i])
                {
                    ControllaTurno(i);
                }
            }
        }
    }
}