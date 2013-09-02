using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //falta: dado sorteado aparecer!!!
        //falta: inserir o n° do ganhador!!!!

        private void bt_gerar_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            
            tb_resultado.Text = numAleatorio.Next(1,7).ToString();

            if (tb_resultado == tb_aposta1)
            {
                tb_ganhador.Text = tb_aposta1.Text;
            }
            else if(tb_resultado == tb_aposta2)
            {
                tb_ganhador.Text = tb_aposta2.Text;
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_aposta1.Clear();
            tb_aposta2.Clear();
            tb_ganhador.Clear();
            tb_resultado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
