using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void img_cima_Click(object sender, EventArgs e)
        {
            if (img_personagem.Left > 0)
            {
                img_personagem.Left = img_personagem.Left - 10;
            }
        }

        private void img_esquerda_Click(object sender, EventArgs e)
        {
            if(img_personagem.Left > 0)
            {
                img_personagem.Left = img_personagem.Left - 10;
            }
        }

        private void img_direita_Click(object sender, EventArgs e)
        {
            if(img_personagem.Left > 600)
            {
                img_personagem.Left = img_personagem.Left + 10;
            }
        }

        private void img_baixo_Click(object sender, EventArgs e)
        {
            if(img_personagem.Left > 600)
            {
                img_personagem.Left = img_personagem.Left + 10;
            }
        }
    }
}
