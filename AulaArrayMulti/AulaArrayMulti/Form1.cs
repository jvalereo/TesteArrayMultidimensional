using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaArrayMulti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            //Aula Teste Array Multidimensional 
            //Jonas Valereo Técnico em Informática 

            //Declarando o codigo Array e instanciando vetor nota e qte de linhas e colunas


            double[,] notas = new double[2, 4];

            notas[0, 0] = 8.0;
            notas[0, 1] = 7.5;
            notas[0, 2] = 9.0;
            notas[0, 3] = 8.5;
            notas[1, 0] = 9.5;
            notas[1, 1] = 8.5;
            notas[1, 2] = 8.0;
            notas[1, 3] = 9.0;

            //Declarando o MessageBox a exibido as devidas notas escolhidas

            MessageBox.Show(notas[0,0].ToString(), "Array");
            MessageBox.Show(notas[0,1].ToString(),"Array");
            MessageBox.Show(notas[0,2].ToString(), "Array");
            MessageBox.Show(notas[0,3].ToString(), "Array");
            MessageBox.Show(notas[1,0].ToString(), "Array");
            MessageBox.Show(notas[1,1].ToString(), "Array");
            MessageBox.Show(notas[1,2].ToString(), "Array");
            MessageBox.Show(notas[1,3].ToString(), "Array");
      

            //Fim do programa 

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo close, sair

            Close();

        }
    }
}