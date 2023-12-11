using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    internal class OrderManager
    {
        private static OrderLinkedList AllOrders;

        private static string file_path = Program.root_path + "\\Arquivos\\pedidos.txt";

        public OrderManager() {
            FetchOrders();
        }

        public static void FetchOrders()
        {
            if (AllOrders != null) { return; }

            AllOrders = new OrderLinkedList();

            string[] allOrders = File.ReadAllLines(file_path);

            foreach (string line in allOrders)
            {
                Pedido novoPedido = new Pedido();
                novoPedido.FillByString(line);
                AllOrders.AddLast(novoPedido);
            }
        }

        public static Pedido GetPedidoByEmail(string email)
        {
            if (AllOrders == null) { FetchOrders(); }
            return AllOrders.FindByEmail(email);
        }
    }
}
