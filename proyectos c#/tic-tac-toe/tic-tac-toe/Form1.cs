using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        string jugador;
        int turnos = 0;
        bool gano = false;

        public Form1()
        {
            InitializeComponent();
            jugar();
        }

        void jugar()
        {

            if (turnos < 9)
            {
                ganador();
                if (turnos % 2 == 0)
                {
                    jugador = "X";
                }
                else
                {
                    jugador = "O";
                }
                tb_principal.Text = tb_principal.Text + "Turno de jugador " + jugador + "\r\n";
                turnos = turnos + 1;
            }
            if (turnos == 9 && !gano)
            {
                MessageBox.Show("empate", "fin del juego");
            }

        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (a1.Text == "-")
            {
                if (jugador == "X")
                {
                    a1.Text = "X";
                    a1.ForeColor = Color.Red;
                }
                else
                {
                    a1.Text = "O";
                    a1.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (a2.Text == "-")
            {
                if (jugador == "X")
                {
                    a2.Text = "X";
                    a2.ForeColor = Color.Red;
                }
                else
                {
                    a2.Text = "O";
                    a2.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (a3.Text == "-")
            {
                if (jugador == "X")
                {
                    a3.Text = "X";
                    a3.ForeColor = Color.Red;
                }
                else
                {
                    a3.Text = "O";
                    a3.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "-")
            {
                if (jugador == "X")
                {
                    b1.Text = "X";
                    b1.ForeColor = Color.Red;
                }
                else
                {
                    b1.Text = "O";
                    b1.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "-")
            {
                if (jugador == "X")
                {
                    b2.Text = "X";
                    b2.ForeColor = Color.Red;
                }
                else
                {
                    b2.Text = "O";
                    b2.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "-")
            {
                if (jugador == "X")
                {
                    b3.Text = "X";
                    b3.ForeColor = Color.Red;
                }
                else
                {
                    b3.Text = "O";
                    b3.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (c1.Text == "-")
            {
                if (jugador == "X")
                {
                    c1.Text = "X";
                    c1.ForeColor = Color.Red;
                }
                else
                {
                    c1.Text = "O";
                    c1.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (c2.Text == "-")
            {
                if (jugador == "X")
                {
                    c2.Text = "X";
                    c2.ForeColor = Color.Red;
                }
                else
                {
                    c2.Text = "O";
                    c2.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (c3.Text == "-")
            {
                if (jugador == "X")
                {
                    c3.Text = "X";
                    c3.ForeColor = Color.Red;
                }
                else
                {
                    c3.Text = "O";
                    c3.ForeColor = Color.Green;
                }
                jugar();
            }
            else
            {
                MessageBox.Show("esta casilla ya esta ocupada" + jugador, "advertencia");
                tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
            }
        }

        void ganador()
        {
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a1.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }
            if (b1.Text == b2.Text && b2.Text == b3.Text)
            {
                if (b1.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }
            if (c1.Text == c2.Text && c2.Text == c3.Text)
            {
                if (c1.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }

            //------------------------------------

            if (a1.Text == b1.Text && b1.Text == c1.Text)
            {
                if (a1.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }
            if (a2.Text == b2.Text && b2.Text == c2.Text)
            {
                if (a2.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }
            if (a3.Text == b3.Text && b3.Text == c3.Text)
            {
                if (a3.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }

            //-----------------------------

            if (a1.Text == b2.Text && b2.Text == c3.Text)
            {
                if (a1.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }
            if (a3.Text == b2.Text && b2.Text == c1.Text)
            {
                if (a3.Text != "-")
                {
                    MessageBox.Show("gano " + jugador, "ganador");
                    tb_principal.Text = tb_principal.Text + "gano el jugador" + jugador + "\r\n";
                    gano = true;
                    desabilita();
                }
            }

        }

        void desabilita()
        {
            a1.Enabled = false;
            a2.Enabled = false;
            a3.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
        }

        void reset()
        {
            a1.Enabled = true;
            a1.Text = "-";
            a1.ForeColor = Color.Black;
            a2.Enabled = true;
            a2.Text = "-";
            a2.ForeColor = Color.Black;
            a3.Enabled = true;
            a3.Text = "-";
            a3.ForeColor = Color.Black;
            b1.Enabled = true;
            b1.Text = "-";
            b1.ForeColor = Color.Black;
            b2.Enabled = true;
            b2.Text = "-";
            b2.ForeColor = Color.Black;
            b3.Enabled = true;
            b3.Text = "-";
            b3.ForeColor = Color.Black;
            c1.Enabled = true;
            c1.Text = "-";
            c1.ForeColor = Color.Black;
            c2.Enabled = true;
            c2.Text = "-";
            c2.ForeColor = Color.Black;
            c3.Enabled = true;
            c3.Text = "-";
            c3.ForeColor = Color.Black;

            turnos = 0;

            tb_principal.Text = "";

        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            reset();
            jugar();
        }


    }
}
