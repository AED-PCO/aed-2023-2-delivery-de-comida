using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    internal class Pedido
    {
        public static int StatusConfirmado = 0;
        public static int StatusEmPreparo = 1;
        public static int StatusEnviado = 2;
        public static int StatusRecebido = 3;

        public string EmailSolicitante;

        public string DataCriacao;
        public string HorarioCriacao;

        public ProductLinkedList Produtos;
        public ProductLinkedList Acompanhamentos;

        public int Status;

        public Pedido()
        {
            DateTime now = DateTime.Now;
            this.DataCriacao = now.ToString("dd/MM/yyyy");
            this.HorarioCriacao = now.ToString("HH:mm");
        }

        public static Pedido GetInstance(string emailSolicitante)
        {
            Pedido jaExiste = OrderManager.GetPedidoByEmail(emailSolicitante);
            if (jaExiste != null)
            {
                return jaExiste;
            }
            Pedido pedido = new Pedido();
            pedido.EmailSolicitante = emailSolicitante;
            DateTime now = DateTime.Now;
            pedido.DataCriacao = now.ToString("dd/MM/yyyy");
            pedido.HorarioCriacao = now.ToString("HH:mm");
            return pedido;
        }

        public void SetProdutos(ProductLinkedList produtos)
        {
            this.Produtos = produtos;
        }

        public void SetAcompanhamentos(ProductLinkedList acompanhamentos)
        {
            this.Acompanhamentos = acompanhamentos;
        }

        public string toString()
        {
            string result = String.Empty;
            result += $"EmailSolicitante={this.EmailSolicitante};" +
                      $"DataCriacao={this.DataCriacao};" +
                      $"HorarioCriacao={this.HorarioCriacao};" +
                      $"Produtos={this.Produtos.toStringOnlyId()};" +
                      $"Acompanhamentos={this.Acompanhamentos.toStringOnlyId()};";
            return result;
        }

        public void FillByString(string data)
        {
            string[] attrs = data.Split(';');
           
            foreach (string attr in attrs)
            {
                string[] line = attr.Split('=');
                FieldInfo propriedade = this.GetType().GetField(line[0]);
                if (propriedade == null) { continue; }

                if (line[0] == "Produtos")
                {
                    ProductLinkedList prodList = ProductManager.GetListByIds(line[1]);
                    this.SetProdutos(prodList);
                }
                else if (line[0] == "Acompanhamentos")
                {
                    ProductLinkedList prodList = ProductManager.GetListByIds(line[1],true);
                    this.SetAcompanhamentos(prodList);
                }
                else
                {
                    if (propriedade.FieldType == typeof(string))
                    {
                        propriedade.SetValue(this, line[1]);
                    }
                    else if (propriedade.FieldType == typeof(float))
                    {
                        propriedade.SetValue(this, float.Parse(line[1]));
                    }
                    else if (propriedade.FieldType == typeof(int))
                    {
                        propriedade.SetValue(this, int.Parse(line[1]));
                    }
                }

            }
        }
    }
}
