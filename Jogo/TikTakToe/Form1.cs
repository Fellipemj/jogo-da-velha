using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        string[,] tabuleiro = new string[3, 3];
        int jogada = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }

        

        

        

        

        private void _1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jogada == 0)
            {
                ReiniciarJogo();
            }

            if (!string.IsNullOrEmpty(txtl.Text) && !string.IsNullOrEmpty(txtc.Text))
            {
                int linha = int.Parse(txtl.Text);
                int coluna = int.Parse(txtc.Text);

                if (ValidaJogada(linha, coluna))
                {
                    tabuleiro[linha, coluna] = (jogada % 2 == 0) ? "X" : "O";
                    jogada++;
                    lbl_aviso.Text = (jogada % 2 == 0) ? "Vez de X jogar" : "Vez de O jogar";

                    if (jogada >= 5 && VerificaVitoria())
                    {
                        lbl_aviso.Text = $"Jogador {(jogada % 2 == 1 ? "X" : "O")} venceu!";
                        jogada = -1;
                    }
                }
                else
                {
                    lbl_aviso.Text = "Jogada inválida! Tente novamente.";
                }
            }
            else
            {
                lbl_aviso.Text = "Insira valores válidos para linha e coluna!";
            }

            MostrarTabuleiro();
            txtl.Clear();
            txtc.Clear();
        }

        private void _2_TextChanged(object sender, EventArgs e)
        {

        }

        private void _3_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidaJogada(int linha, int coluna)
        {
            return linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] == "";
        }

        private void ReiniciarJogo()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = "";
                }
            }
            jogada = 0;
            lbl_aviso.Text = "Vez de X jogar";
            MostrarTabuleiro();
        }

        private void _4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarTabuleiro()
        {
            _1.Text = tabuleiro[0, 0];
            _2.Text = tabuleiro[0, 1];
            _3.Text = tabuleiro[0, 2];
            _4.Text = tabuleiro[1, 0];
            _5.Text = tabuleiro[1, 1];
            _6.Text = tabuleiro[1, 2];
            _7.Text = tabuleiro[2, 0];
            _8.Text = tabuleiro[2, 1];
            _9.Text = tabuleiro[2, 2];
        }

        private void _5_TextChanged(object sender, EventArgs e)
        {

        }

        private void _6_TextChanged(object sender, EventArgs e)
        {

        }

        private void _7_TextChanged(object sender, EventArgs e)
        {

        }

        private bool VerificaVitoria()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] != "" && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                    return true;
                if (tabuleiro[0, i] != "" && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                    return true;
            }

            if (tabuleiro[0, 0] != "" && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
                return true;

            if (tabuleiro[0, 2] != "" && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                return true;

            return false;
        }

        private void _8_TextChanged(object sender, EventArgs e)
        {

        }

        private void _9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

