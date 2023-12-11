using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            ProductManager.FetchAllProducts();
            OrderManager.FetchOrders();
            InitializeComponent();
            this.PreencheCards();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 TelaHamburgueres = new Form3();
            TelaHamburgueres.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PreencheCards()
        {
            Product[] produtos = ProductManager.GetAllExtras();

            Label[] camposNome = { nome1, nome2, nome3, nome4, nome5, nome6, nome7, nome8, nome9, nome10 };
            PictureBox[] camposFoto = { foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8, foto9, foto10 };
            Label[] camposPreco = { preco1, preco2, preco3, preco4, preco5, preco6, preco7, preco8, preco9, preco10 };

            for (int i = 0; i < produtos.Length; i++)
            {
                camposNome[i].Text = produtos[i].Nome;
                camposFoto[i].Image = produtos[i].GetImageObject();
                camposPreco[i].Text = "R$" + produtos[i].Preco.ToString("0.00");
            }
        }
    }
}
