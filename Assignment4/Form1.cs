using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {

        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The game is played on a grind that's 3 squares by 3 squares." +
               
               " 2. You are X, your friend is O. Players take turn putting their marks in empty squares. 3. The first player to get 3 of her marks in a row" +
               "(up, down, across, or diagonally) is the winner. 4. When all 9 squares are full, the game will display draw. When there is already a winner, the game is over. Goodluck!!!", "Tic Tac Toe Instruction");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (turn)
                x.Text = "X";
            else
                x.Text = "O";

            turn = !turn;
            x.Enabled = false;
            turn_count++;
            forWinner();
        }
        private void forWinner()
        {
            bool Congratulations = false;

            //HORIZONTAL pows
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                Congratulations = true;
            else if ((U1.Text == U2.Text) && (U2.Text == U3.Text) && (!U1.Enabled))
                Congratulations = true;
            else if ((T1.Text == T2.Text) && (T2.Text == T3.Text) && (!T1.Enabled))
                Congratulations = true;


            //VERTICAL this
            else if ((B1.Text == U1.Text) && (U1.Text == T1.Text) && (!B1.Enabled))
                Congratulations = true;
            else if ((B2.Text == U2.Text) && (U2.Text == T2.Text) && (!B2.Enabled))
                Congratulations = true;
            else if ((B3.Text == U3.Text) && (U3.Text == T3.Text) && (!B3.Enabled))
                Congratulations = true;

            //SLANT HAHA
            else if ((B1.Text == U2.Text) && (U2.Text == T3.Text) && (!B1.Enabled))
                Congratulations = true;
            else if ((B3.Text == U2.Text) && (U2.Text == T1.Text) && (!T1.Enabled))
                Congratulations = true;
         


            if (Congratulations)
            {
                disableButtons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("Congratulations, player " + winner + " You win!!!!", "WOOOOOHHHH!!!");

            }

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("There is a draw!", "Wait...");
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {

                    Button x = (Button)c;
                    x.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
            try
            {
                foreach (Control c in Controls)
                {

                    Button x = (Button)c;
                    x.Enabled = true;
                    x.Text = "";
                }
            }
            catch { }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A game for fun. Made and programmed by Dulce Fietas, BSCPE Student of PUP uwu.", "Tic Tac Toe About");
        }

        
    }
    }

