using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Gerarpedido();
            Produtos();
        }

        private void Gerarpedido()
        {
            listView1.Columns.Add("Codigo", 25).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Descrição", 115);
            listView1.Columns.Add("UN", 25).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Valor", 45).TextAlign = HorizontalAlignment.Right;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;
        }

        public void Produtos()
        {
            Pedido pedido = OrderManager.GetPedidoByEmail(UserManager.LoggedUserEmail);

            Product produto = pedido.Produtos.GetNext();

            while (produto != null)
            {
                string[] item = new string[4];

                item[0] = produto.Id.ToString();
                item[1] = produto.Nome;
                item[2] = produto.Quantidade.ToString();
                item[3] = produto.Preco.ToString("0.00");
                listView1.Items.Add(new ListViewItem(item));

                produto = pedido.Produtos.GetNext();
            }

        }



       
    }
}