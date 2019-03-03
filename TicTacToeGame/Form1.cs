using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public int player = 2; // even X turn; odd = 0 turn
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void Form1_Load(object sender, EventArgs e) {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void ButtonClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button.Text == "") {
                if (player % 2 == 0) {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if (CheckDraw()) {
                    MessageBox.Show("Dead heat!");
                    sd++;
                    NewGame();
                }
                if (CheckWinner()) {
                    if (button.Text == "X") {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        bool CheckWinner() {
            // Horizontal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;
            // Vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;
            // Diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A22.Text != ""))
                return true;
            else if ((A20.Text == A11.Text) && (A11.Text == A02.Text) && (A02.Text != ""))
                return true;
            else
                return false;
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        void NewGame() {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void NGameBtn_Click(object sender, EventArgs e) {
            NewGame();
        }

        bool CheckDraw() {
            if ((turns == 9) && !CheckWinner())
                return true;
            else
                return false;
        }

        private void ResBtn_Click(object sender, EventArgs e) {
            s1 = 0;
            s2 = 0;
            sd = 0;
            NewGame();
        }
    }
}
