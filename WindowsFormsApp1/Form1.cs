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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ENTRAR_Click(object sender, EventArgs e)
        {

            string email = textBox2.Text;
            string pass = textBox1.Text;

            if (email == String.Empty || pass == String.Empty)
            {
                MessageBox.Show("Favor informar todos os campos.","Campos obrigatórios");
                return;
            }

            UserManager UM = new UserManager();

            int result = UM.Login(email,pass);

            switch (result)
            {
                case 0:
                    DialogResult DR = MessageBox.Show("Bem vindo/a!", "Sucesso!");
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        this.Close();
                    }
                    break;
                case 1:
                    MessageBox.Show("Senha incorreta.", "Falha no login");
                    break;
                case 2:
                    MessageBox.Show("Usuário não encontrado.", "Falha no login");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CADASTRO telaCadastro = new CADASTRO();
            this.Hide();
            telaCadastro.ShowDialog();
            this.Close();
        }
    }
}
